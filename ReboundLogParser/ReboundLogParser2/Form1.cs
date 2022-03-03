using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using CefSharp.WinForms;

namespace ReboundLogParser2 {
    public partial class Form1 : Form
    {
        static List<stats> _homeTeamPlayers = new List<stats>();
        static List<stats> _awayTeamPlayers = new List<stats>();
        static int _homeScore;
        static int _awayScore;
        static int _period;
        static string _currentPeriod;
        static bool _overTime = false;
        static string _loadedFile;
        static bool _multipleFiles = false;
        const string WRONGPERIODTEXT = "The log file entered is not the 3rd period";
        const string MULTIPLEFILESTEXT = "Multiple log files in log folder";
        private ChromiumWebBrowser _browser;
        private List<string> _homePlayers = null;
        private List<string> _awayPlayers = null;
        private List<ComboBox> _homePlayerBoxes;
        private List<ComboBox> _awayPlayerBoxes;

        public Form1()
        {
            CefSettings cefSettings = new CefSettings();
            CefSharp.Cef.EnableHighDPISupport();
            CefSharp.Cef.Initialize(cefSettings);

            InitializeComponent();
            _homePlayerBoxes = new List<ComboBox>() { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5 };
            _awayPlayerBoxes = new List<ComboBox>() { comboBox6, comboBox7, comboBox8, comboBox9, comboBox10 };

            _browser = new ChromiumWebBrowser("https://a.leaguerepublic.com/myaccount/login/index.html?lver=2");
            cefPanel1.Controls.Add(_browser);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLogFiles();
        }

        private void LoadLogsButton_Click(object sender, EventArgs e)
        {
            LoadLogFiles();
        }

        private void LoadLogFiles()
        {
            ResetFormData();
            LoadAndParseLogFiles();
            SetLoadedFileDisplays();
            SetTeamAndPeriodLabels();
            CheckOvertimeWin();
            PopulateDataGrid();
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
            MultipleFiles.Visible = false;

            _multipleFiles = false;
            _loadedFile = String.Empty;
            _homeScore = 0;
            _awayScore = 0;
        }

        static void LoadAndParseLogFiles()
        {
            string[] filePaths = Directory.GetFiles(@".\Logs\", "*.json",
                                               SearchOption.TopDirectoryOnly);

            for (int m = 0; m < filePaths.Length; m++)
            {
                ParseJson(@filePaths[m]);
                _loadedFile += (@filePaths[m] + "   ");
            }
            if (filePaths.Length > 1)
            {
                _multipleFiles = true;
            }
            else if (filePaths.Length < 1)
            {
                _loadedFile = "Problem Loading File";
            }
        }

        private void SetLoadedFileDisplays()
        {
            MultipleFiles.Text = MULTIPLEFILESTEXT;
            MultipleFiles.Visible = _multipleFiles;
            LogFileName.Text = _loadedFile;
        }

        private void SetTeamAndPeriodLabels()
        {
            HomeTeam.Text = "Home Team: " + _homeScore.ToString();
            AwayTeam.Text = "Away Team: " + _awayScore.ToString();
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
            awayDataGrid.DataSource = _awayTeamPlayers;
        }

        static void ParseJson(string fileName)
        {
            dynamic o1 = JObject.Parse(File.ReadAllText(fileName));
            _overTime = CheckOvertime(o1);
            string homeScoreString = o1.score.home;
            string awayScoreString = o1.score.away;
            string periodString = o1.current_period;
            _homeScore += int.Parse(homeScoreString);
            _awayScore += int.Parse(awayScoreString);
            _period = int.Parse(periodString);
            _currentPeriod = o1.current_period;
            foreach (dynamic player in o1.players)
            {
                var isHomeTeam = player.team == "home";
                var teamToBuild = isHomeTeam ? _homeTeamPlayers : _awayTeamPlayers;
                if (PlayerExists(player, teamToBuild))
                {
                    for (int p = 0; p < teamToBuild.Count; p++)
                    {
                        if (teamToBuild[p].PlayerName == player.username.ToString())
                        {
                            teamToBuild[p].addValues(player);
                        }
                    }
                }
                else
                {
                    teamToBuild.Add(new stats(player));
                }
            }
            _homeTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
            _awayTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
        }

        static bool CheckOvertime(dynamic statsObject)
        {
            bool returnBool = false;
            double homeTeamOT = 0;
            double awayTeamOT = 0;
            
            for (int i = 0; i < 5; i++)
            {
                if (statsObject.players[i].team == "away")
                {
                    break;
                }

                try
                {
                    homeTeamOT = statsObject.players[i].stats.overtime_wins;
                }
                catch
                {
                    homeTeamOT = 0;
                }

                if (homeTeamOT == 0)
                {
                    try
                    {
                        awayTeamOT = statsObject.players[i].stats.overtime_losses;
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

        static bool PlayerExists(dynamic passedPlayer, List<stats> playerArray)
        {
            bool returnValue = false;
            for (int j = 0; j < playerArray.Count; j++)
            {
                if (playerArray[j].PlayerName == passedPlayer.username.ToString())
                {
                    returnValue = true;
                }
            }
            return returnValue;
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
                box.Items.AddRange(players.ToArray<object>());
            }
        }

        private void ClearTeamComboBoxes(bool isHomeTeam)
        {
            var playerBoxes = isHomeTeam ? _homePlayerBoxes : _awayPlayerBoxes;
            foreach (var box in playerBoxes)
            {
                box.SelectedIndex = -1;
                box.Items.Clear();
            }
        }

        private void SendStatsButton_Click(object sender, EventArgs e)
        {
            var isHomeTeam = (sender as Button).Name == "SendHomeStatsButton";
            FillStatsInWebForm(isHomeTeam);
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

            var boxesWithDuplicateSelections = teamBoxes.GroupBy(b => b.SelectedItem)
                .Where(g => g.Count() > 1 && g.Key != null)
                .Select(a => a.Key)
                .ToList();
            foreach (var dupePlayer in boxesWithDuplicateSelections)
            {
                if (dupePlayer != null)
                {
                    var boxes = teamBoxes.Select(x => x)
                        .Where(y => y.SelectedItem != null
                            && y.SelectedItem.Equals(dupePlayer));
                    foreach (var box in boxes)
                    {
                        box.BackColor = System.Drawing.Color.Red;
                    }
                }
            }

            var boxesWithoutDuplicateSelections = teamBoxes.GroupBy(a => a.SelectedItem)
                .Where(g => g.Count() <= 1 || g.Key == null)
                .Select(b => b.Key)
                .ToList();
            foreach (var nonDupePlayer in boxesWithoutDuplicateSelections)
            {
                if (nonDupePlayer != null)
                {
                    var boxes = teamBoxes.Select(x => x)
                        .Where(y => y.SelectedItem == null
                            || y.SelectedItem.Equals(nonDupePlayer));
                    foreach (var box in boxes)
                    {
                         box.BackColor = default;
                    }
                }
            }

            var selectedTeamStatsButton = isHomeTeamBox ? SendHomeStatsButton : SendAwayStatsButton;
            selectedTeamStatsButton.Enabled = boxesWithDuplicateSelections.Count() == 0;
        }
    }
}
