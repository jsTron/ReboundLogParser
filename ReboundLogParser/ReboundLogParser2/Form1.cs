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
        private CefSharp.JavascriptResponse _result;
        private List<string> _homePlayers = null;
        private List<string> _awayPlayers = null;
        private List<ComboBox> _homePlayerBoxes;
        private List<ComboBox> _awayPlayerBoxes;

        public Form1()
        {
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
            _awayTeamPlayers.Clear();
            ClearAllComboBoxes();

            homeDataGrid.DataSource = null;
            awayDataGrid.DataSource = null;
            homeDataGrid.Rows.Clear();
            awayDataGrid.Rows.Clear();
            MultipleFiles.Visible = false;

            _multipleFiles = false;
            _loadedFile = "";
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
                if (_homeScore > _awayScore)
                {
                    HomeOT.Visible = true;
                }
                else
                {
                    AwayOT.Visible = true;
                }
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
                if (player.team == "home")
                {
                    if (PlayerExists(player, _homeTeamPlayers))
                    {
                        for (int p = 0; p < _homeTeamPlayers.Count; p++)
                        {
                            if (_homeTeamPlayers[p].PlayerName == player.username.ToString())
                            {
                                _homeTeamPlayers[p].addValues(player);
                            }
                        }
                    }
                    else
                    {
                        _homeTeamPlayers.Add(new stats(player));
                    }
                }
                else
                {
                    if (PlayerExists(player, _awayTeamPlayers))
                    {
                        for (int p = 0; p < _awayTeamPlayers.Count; p++)
                        {
                            if (_awayTeamPlayers[p].PlayerName == player.username.ToString())
                            {
                                _awayTeamPlayers[p].addValues(player);
                            }
                        }
                    }
                    else
                    {
                        _awayTeamPlayers.Add(new stats(player));
                    }
                }
            }
            _homeTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
            _awayTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
        }

        static bool CheckOvertime(dynamic statsObject)
        {
            bool returnBool = false;
            double homeTeamOT;
            double awayTeamOT;

            try
            {
                homeTeamOT = statsObject.players[0].stats.overtime_wins;
            }
            catch
            {
                homeTeamOT = 0;
            }

            try
            {
                awayTeamOT = statsObject.players[0].stats.overtime_losses;
            }
            catch
            {
                awayTeamOT = 0;
            }

            if (awayTeamOT == 1 || homeTeamOT == 1)
            {
                returnBool = true;
            }
            return returnBool;
        }

        static bool PlayerExists(dynamic passedPlayer, List<stats> playerArray)
        {
            Boolean returnValue = false;

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
            _result = null;

            // Find out what team should have names loaded to ComboBoxes
            var isHomeTeam = (sender as Button).Name == "button1" ? true : false;

            _result = await _browser.GetBrowser().MainFrame.EvaluateScriptAsync(
                "function foo() {players = new Array();" +
                "rows = document.getElementsByClassName(\"sticky-col\")[0].getElementsByTagName(\"tr\");" +
                "for (i = 0; i < rows.length; i++)" +
                "{" +
                "players.push(rows[i].getElementsByTagName(\"th\")[0].innerHTML.toString().trim());" +
                "}" +
                "return players;}" +
                "foo();"
            );

            if (_result != null && _result.Success)
            {
                var x = _result.Result as List<object>;
                x.RemoveAt(0);
                // y contains the list of players displayed on the entry form of team statistics in row index order
                if (isHomeTeam)
                {
                    _homePlayers = x.OfType<string>().ToList();
                    ClearHomeComboBoxes();
                }
                else
                {
                    _awayPlayers = x.OfType<string>().ToList();
                    ClearAwayComboBoxes();
                }
                PopulateComboBoxes(isHomeTeam ? _homePlayers : _awayPlayers, isHomeTeam);
            }
        }

        private void PopulateComboBoxes(List<string> players, bool isHomeTeam)
        {
            if (isHomeTeam)
            {
                foreach (var box in _homePlayerBoxes)
                {
                    box.Items.Clear();
                    box.Items.AddRange(players.ToArray<object>());
                }
            }
            else
            {
                foreach (var box in _awayPlayerBoxes)
                {
                    box.Items.Clear();
                    box.Items.AddRange(players.ToArray<object>());
                }
            }
        }

        private void ClearAllComboBoxes()
        {
            var comboBoxes = _homePlayerBoxes;
            comboBoxes.AddRange(_awayPlayerBoxes);

            foreach (var box in comboBoxes)
            {
                box.SelectedIndex = -1;
                box.Items.Clear();
            }
        }

        private void ClearHomeComboBoxes()
        {
            foreach (var box in _homePlayerBoxes)
            {
                box.SelectedIndex = -1;
                box.Items.Clear();
            }
        }

        private void ClearAwayComboBoxes()
        {
            foreach (var box in _awayPlayerBoxes)
            {
                box.SelectedIndex = -1;
                box.Items.Clear();
            }
        }

        private void SendHomeStatsButton_Click(object sender, EventArgs e)
        {
            bool isHomeTeam = true;
            FillStatsInWebForm(isHomeTeam);
        }

        private void SendAwayStatsButton_Click(object sender, EventArgs e)
        {
            bool isHomeTeam = false;
            FillStatsInWebForm(isHomeTeam);
        }

        private void FillStatsInWebForm(bool isHomeTeam)
        {
            var teamPlayerBoxes = _awayPlayerBoxes;
            var teamPlayers = _awayTeamPlayers;
            if (isHomeTeam)
            {
                teamPlayerBoxes = _homePlayerBoxes;
                teamPlayers = _homeTeamPlayers;
            }

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
    }
}
