using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CefSharp.WinForms;
using Newtonsoft.Json;

namespace ReboundLogParser {
    public partial class MainForm : Form
    {
        static List<stats> _homeTeamPlayers = new List<stats>();
        static List<stats> _awayTeamPlayers = new List<stats>();
        static int _homeScore;
        static int _awayScore;
        static int _period;
        static string _currentPeriod;
        static bool _overTime = false;
        static string _loadedFile;
        static List<string> _loadedFiles = new List<string>();
        static List<string> _lastLoadedFiles = new List<string>();
        static bool _multipleFiles = false;
        const string WRONGPERIODTEXT = "No Per. 3 log!";
        const string MULTIPLEFILESTEXT = "Multi-log Mode!";
        const string INVALIDJSONTEXT = "Invalid JSON!";
        private ChromiumWebBrowser _browser;
        private List<ComboBox> _homePlayerBoxes;
        private List<ComboBox> _awayPlayerBoxes;
        private List<Match> _parsedLogs = new List<Match>();

        public MainForm()
        {
            CefSettings cefSettings = new CefSettings();
            CefSharp.Cef.Initialize(cefSettings);

            InitializeComponent();
            _homePlayerBoxes = new List<ComboBox>() { homePlayerBox1, homePlayerBox2, homePlayerBox3, homePlayerBox4, homePlayerBox5,
                homePlayerBox6, homePlayerBox7, homePlayerBox8, homePlayerBox9, homePlayerBox10 };
            _awayPlayerBoxes = new List<ComboBox>() { awayPlayerBox1, awayPlayerBox2, awayPlayerBox3, awayPlayerBox4, awayPlayerBox5,
                awayPlayerBox6, awayPlayerBox7, awayPlayerBox8, awayPlayerBox9, awayPlayerBox10 };
            _homePlayerBoxes.ForEach(box => box.Enabled = false);
            _awayPlayerBoxes.ForEach(box => box.Enabled = false);
            loadHomePlayersButton.Enabled = false;
            loadAwayPlayersButton.Enabled = false;
            SendHomeStatsButton.Enabled = false;
            SendAwayStatsButton.Enabled = false;

            _browser = new ChromiumWebBrowser("https://a.leaguerepublic.com/myaccount/login/index.html?lver=2");
            cefPanel1.Controls.Add(_browser);
        }

        private void LoadLogsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var fileTemp = dialog.FileNames.ToList();
                    if (!_loadedFiles.Any(x => fileTemp.Contains(x)))
                    {
                        _loadedFiles.AddRange(fileTemp);
                    }
                    LoadLogFiles(_loadedFiles);
                }
            }
        }

        private void LoadLogFiles(List<string> fileNames = null)
        {
            ResetFormData();
            bool success = LoadAndParseLogFiles(fileNames);
            SetLoadedFileDisplays();
            if (!success)
            {
                MultipleFiles.Text = INVALIDJSONTEXT;
                MultipleFiles.Visible = true;
                if (fileNames != null)
                {
                    _loadedFiles.RemoveAll(file => fileNames.Contains(file) && !_lastLoadedFiles.Contains(file));
                }  
            }
            SetTeamAndPeriodLabels();
            CheckOvertimeWin();
            PopulateDataGrid();
            _lastLoadedFiles = new List<string>(_loadedFiles);

            if (homeDataGrid.Rows.Count > 0)
            {
                loadHomePlayersButton.Enabled = true;
            }
            if (awayDataGrid.Rows.Count > 0)
            {
                loadAwayPlayersButton.Enabled = true;
            }
        }

        private void ResetFormData()
        {
            _homeTeamPlayers.Clear();
            ClearTeamComboBoxes(true);
            _awayTeamPlayers.Clear();
            ClearTeamComboBoxes(false);

            homeDataGrid.DataSource = null;
            awayDataGrid.DataSource = null;
            homeDataGrid.Rows.Clear();
            awayDataGrid.Rows.Clear();
            loadHomePlayersButton.Enabled = false;
            loadAwayPlayersButton.Enabled = false;
            MultipleFiles.Visible = false;

            _multipleFiles = false;
            _loadedFile = String.Empty;
            _homeScore = 0;
            _awayScore = 0;
            _period = 0;
            SetTeamAndPeriodLabels();
            _overTime = false;
            CheckOvertimeWin();
            _loadedFile = String.Empty;
            LogFileName.Text = String.Empty;
        }

        private bool LoadAndParseLogFiles(List<string> fileNames = null)
        {
            bool success = false;
            fileNames = fileNames ?? new List<string>();
            _parsedLogs.Clear();
            foreach (var fileName in fileNames)
            {
                success = ParseJson(fileName);
                if (!success)
                {
                    return success; // Will return false here
                }
                _loadedFile += $"{fileName}; ";
            }
            TabulateSelectedLogs();

            _multipleFiles = fileNames.Count > 1;
            _loadedFile = (fileNames.Count() < 1) ? "Problem Loading Files!" : _loadedFile;

            return success; // True if successful, false if no files
        }

        private void SetLoadedFileDisplays()
        {
            MultipleFiles.Text = MULTIPLEFILESTEXT;
            MultipleFiles.Visible = _multipleFiles;
            LogFileName.Text = _loadedFile;
        }

        private void SetTeamAndPeriodLabels()
        {
            HomeTeam.Text = $"Home Team: {_homeScore}";
            AwayTeam.Text = $"Away Team: {_awayScore}";
            periodLabel.Text = _period.ToString();

            if (_currentPeriod != "3")
            {
                MultipleFiles.Text = WRONGPERIODTEXT;
                MultipleFiles.Visible = true;
            }
        }

        private void CheckOvertimeWin()
        {
            if (_overTime)
            {
                bool isHomeWinningOvertimeTeam = _homeScore > _awayScore;
                HomeOT.Visible = isHomeWinningOvertimeTeam;
                AwayOT.Visible = !isHomeWinningOvertimeTeam;
            }
            else
            {
                HomeOT.Visible = false;
                AwayOT.Visible = false;
            }
        }

        private void PopulateDataGrid()
        {
            homeDataGrid.DataSource = _homeTeamPlayers;
            homeDataGrid.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCellsExceptHeader);
            homeDataGrid.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCellsExceptHeader);
            awayDataGrid.DataSource = _awayTeamPlayers;
            awayDataGrid.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCellsExceptHeader);
            awayDataGrid.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCellsExceptHeader);
        }

        private bool ParseJson(string fileName)
        {
            Match parsedPeriod = null;
            try
            {
                parsedPeriod = JsonConvert.DeserializeObject<Match>(File.ReadAllText(fileName));
            }
            catch (JsonReaderException jex)
            {
                _loadedFile = $"Problem Loading Files: {jex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                _loadedFile = $"Problem Loading Files: {ex.Message}";
                return false;
            }

            _parsedLogs.Add(parsedPeriod);

            return true;
        }

        private bool TabulateSelectedLogs()
        {
            _parsedLogs.Sort(delegate (Match m1, Match m2) { return m1.CurrentPeriod.CompareTo(m2.CurrentPeriod); });
            Match period3 = _parsedLogs.Last();
            
            foreach (Player player in period3.Players)
            {
                // Get and store period player stat sums
                var sums = new List<PlayerStatSums>();
                foreach (Match m in _parsedLogs)
                {
                    var playerSum = new PlayerStatSums();
                    playerSum.GameUserId = player.GameUserId;
                    playerSum.CurrentPeriod = m.CurrentPeriod;
                    try
                    {
                        playerSum.StatSum = SumPlayerStats(m.Players.Single(p => p.GameUserId.Equals(player.GameUserId)));
                    }
                    catch
                    {
                        continue;
                    }

                    sums.Add(playerSum);
                }

                int periodsPlayed = 1;
                if (sums.Count > 1)
                {
                    for (int i = 1; i < sums.Count; i++)
                    {
                        if (!sums[i].StatSum.Equals(sums[i - 1].StatSum))
                        {
                            periodsPlayed++;
                        }
                    }
                }
                else
                {
                    periodsPlayed = 1;
                }

                // Save player periods played
                player.Stats.GamesPlayed = periodsPlayed;
            }

            _overTime = CheckOvertime(period3);
            _homeScore += period3.Score.Home;
            _awayScore += period3.Score.Away;
            _period = int.Parse(period3.CurrentPeriod);
            _currentPeriod = period3.CurrentPeriod;
            foreach (Player player in period3.Players)
            {
                var isHomeTeam = player.Team == "home";
                var teamToBuild = isHomeTeam ? _homeTeamPlayers : _awayTeamPlayers;
                    teamToBuild.Add(new stats(player));
            }
            _homeTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
            _awayTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });

            return true;
        }

        private bool CheckOvertime(Match statsObject)
        {
            bool returnBool = false;
            double homeTeamOT = 0;
            double awayTeamOT = 0;
            
            for (int i = 0; i < 5; i++)
            {
                if (statsObject.Players[i].Team == "away")
                {
                    break;
                }

                try
                {
                    homeTeamOT = statsObject.Players[i].Stats.OvertimeWins;
                }
                catch
                {
                    homeTeamOT = 0;
                }

                if (homeTeamOT == 0)
                {
                    try
                    {
                        awayTeamOT = statsObject.Players[i].Stats.OvertimeLosses;
                    }
                    catch
                    {
                        awayTeamOT = 0;
                    }
                }

                if (homeTeamOT == 1 || awayTeamOT == 1)
                {
                    break;
                }
            }

            if (awayTeamOT == 1 || homeTeamOT == 1)
            {
                returnBool = true;
            }

            return returnBool;
        }

        public double SumPlayerStats(Player player)
        {
            double sum = player.Stats.Assists +
                player.Stats.Blocks +
                player.Stats.ConcededGoals +
                player.Stats.ContributedGoals +
                player.Stats.FaceoffsLost +
                player.Stats.FaceoffsWon +
                // This stat is broken, do not use!!
                //player.Stats.GamesPlayed +
                player.Stats.GameWinningGoals +
                player.Stats.Goals +
                player.Stats.Losses +
                player.Stats.OvertimeLosses +
                player.Stats.OvertimeWins +
                player.Stats.Passes +
                player.Stats.PossessionTimeSec +
                player.Stats.PostHits +
                player.Stats.PrimaryAssists +
                player.Stats.Saves +
                player.Stats.Score +
                player.Stats.SecondaryAssists +
                player.Stats.Shots +
                player.Stats.Shutouts +
                player.Stats.ShutoutsAgainst +
                player.Stats.Takeaways +
                player.Stats.Turnovers +
                player.Stats.Wins;
            return sum;
        }

        private async void TeamPlayersLoadButton_Click(object sender, EventArgs e)
        {
            // Find out what team should have names loaded to ComboBoxes
            var isHomeTeam = (sender as Button).Name == "loadHomePlayersButton";

            CefSharp.JavascriptResponse result = await _browser.GetBrowser().MainFrame.EvaluateScriptAsync(
                "function foo() {players = new Array();" +
                "rows = document.getElementsByClassName(\"sticky-col\")[0].getElementsByTagName(\"tr\");" +
                "for (i = 0; i < rows.length; i++)" +
                "{" +
                "players.push(rows[i].getElementsByTagName(\"th\")[0].innerHTML.toString().trim());" +
                "}" +
                "return players;}" +
                "foo();"
            );

            if (result != null && result.Success)
            {
                var playerNames = result.Result as List<object>;
                playerNames.RemoveAt(0); // Remove the "Name" column heading.
                List<string> playerNameStringList = playerNames.OfType<string>().ToList();
                PopulateComboBoxes(playerNameStringList, isHomeTeam);
            }
        }

        private void PopulateComboBoxes(List<string> players, bool isHomeTeam)
        {
            var playerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            ClearTeamComboBoxes(isHomeTeam);
            foreach (var box in playerBoxes)
            {
                var dataGrid = isHomeTeam ? homeDataGrid : awayDataGrid;
                if (!dataGrid.Rows.Count.Equals(0) && playerBoxes.IndexOf(box) < dataGrid.Rows.Count)
                {
                    box.Enabled = true;
                    box.Items.AddRange(players.ToArray<object>());
                }
            }
        }

        private void ClearTeamComboBoxes(bool isHomeTeam)
        {
            var playerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            foreach (var box in playerBoxes)
            {
                box.SelectedIndex = -1;
                box.Items.Clear();
                box.Enabled = false;
            }
        }

        private void SendStatsButton_Click(object sender, EventArgs e)
        {
            var isHomeTeam = (sender as Button).Name == "SendHomeStatsButton";
            var playerBoxesFilled = !(isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes)
                .Any(box => box.SelectedIndex.Equals(-1) && box.Enabled.Equals(true));
            if (playerBoxesFilled)
            {
                FillStatsInWebForm(isHomeTeam);
            }
        }

        private void FillStatsInWebForm(bool isHomeTeam)
        {
            var teamPlayerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            var teamPlayers = isHomeTeam ? _homeTeamPlayers : _awayTeamPlayers;
            var frame = _browser.GetBrowser().MainFrame;

            foreach (var cb in teamPlayerBoxes)
            {
                if (cb.SelectedIndex > -1)
                {
                    var values = Enum.GetValues(typeof(StatsEnum));
                    foreach (StatsEnum stat in values)
                    { 
                        var cbIndex = teamPlayerBoxes.IndexOf(cb);
                        frame.ExecuteJavaScriptAsync(
                            $"document.getElementsByTagName(\"tbody\")[0]" +
                            $".getElementsByTagName(\"tr\")[{cb.SelectedIndex}]" +
                            $".getElementsByTagName(\"td\")[{(int)stat}]" +
                            $".getElementsByTagName(\"input\")[0].value = {teamPlayers[cbIndex].GetPropertyValueByEnum(stat)};"
                        );
                    }
                }
            }
        }

        private void TeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changedComboBox = (sender as ComboBox);
            var isHomeTeamBox = _homePlayerBoxes.Any(box => box.Name.Equals(changedComboBox.Name));
            var teamBoxes = (isHomeTeamBox ? _homePlayerBoxes : _awayPlayerBoxes);

            var boxesWithDuplicateSelections = teamBoxes.GroupBy(box => box.SelectedItem)
                .Where(groupings => groupings.Count() > 1 && groupings.Key != null)
                .Select(boxBySelectedItem => boxBySelectedItem.Key)
                .ToList();
            foreach (var dupePlayer in boxesWithDuplicateSelections)
            {
                if (dupePlayer != null)
                {
                    var boxes = teamBoxes.Select(box => box)
                        .Where(selectedBox => selectedBox.SelectedItem != null
                            && selectedBox.SelectedItem.Equals(dupePlayer));
                    foreach (var box in boxes)
                    {
                        box.BackColor = System.Drawing.Color.Red;
                    }
                }
            }

            var boxesWithoutDuplicateSelections = teamBoxes.GroupBy(box => box.SelectedItem)
                .Where(groupings => groupings.Count() <= 1 || groupings.Key == null)
                .Select(boxBySelectedItem => boxBySelectedItem.Key)
                .ToList();
            foreach (var nonDupePlayer in boxesWithoutDuplicateSelections)
            {
                if (nonDupePlayer != null)
                {
                    var boxes = teamBoxes.Select(box => box)
                        .Where(boxBySelectedItem => boxBySelectedItem.SelectedItem == null
                            || boxBySelectedItem.SelectedItem.Equals(nonDupePlayer));
                    foreach (var box in boxes)
                    {
                         box.BackColor = default;
                    }
                }
            }

            var selectedTeamStatsButton = isHomeTeamBox ? SendHomeStatsButton : SendAwayStatsButton;
            var selectedTeamBoxes = isHomeTeamBox ? _homePlayerBoxes : _awayPlayerBoxes;
            selectedTeamStatsButton.Enabled = boxesWithDuplicateSelections.Count() == 0
                && !selectedTeamBoxes.Any(box => box.Enabled.Equals(true) && box.SelectedIndex.Equals(-1));
        }

        private void DragDropPanel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DragDropPanel_DragDrop(object sender, DragEventArgs e)
        {
            var dropFiles = e.Data.GetData(DataFormats.FileDrop); // get all files dropped
            List<string> files = new List<string>();
            files.AddRange((dropFiles as string[]).ToList()); ;
            if (files != null && files.Any())
            {
                foreach (var file in files)
                {
                    if (!_loadedFiles.Contains(file))
                    {
                        _loadedFiles.Add(file);
                    }
                }
                LoadLogFiles(_loadedFiles);
            }
        }

        private void ClearLogsButton_Click(object sender, EventArgs e)
        {
            _loadedFiles.Clear();
            _lastLoadedFiles.Clear();
            _parsedLogs.Clear();
            ResetFormData();
            MultipleFiles.Visible = false;
        }
    }
}
