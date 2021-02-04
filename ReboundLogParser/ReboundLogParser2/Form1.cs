using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ReboundLogParser2 {
  public partial class Form1 : Form {
    static List<stats> homeTeamPlayers = new List<stats>();
    static List<stats> awayTeamPlayers = new List<stats>();
    static int homeScore;
    static int awayScore;
    static string currentPeriod;
    static bool OT = false;
    static string loadedFile;
    static bool multipleFiles = false;
    const string WRONGPERIODTEXT = "The log file entered is not the 3rd period of a game.";
    const string MULTIPLEFILESTEXT = "Multiple log files in log folder";
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      loadFiles();
      HomeTeam.Text = "Home Team: " + homeScore.ToString();
      AwayTeam.Text = "Away Team: " + awayScore.ToString();
      if (OT) {
        if (homeScore > awayScore) {
          HomeOT.Visible = true;
        }
        else {
          AwayOT.Visible = true;
        }
      }
      MultipleFiles.Visible = multipleFiles;
      if(currentPeriod != "3"){
        MultipleFiles.Text = WRONGPERIODTEXT;
        MultipleFiles.Visible = true;
      }
      LogFileName.Text = loadedFile;
      homeDataGrid.DataSource = homeTeamPlayers;
      awayDataGrid.DataSource = awayTeamPlayers;

    }

    private void button1_Click(object sender, EventArgs e) {
      homeTeamPlayers.Clear();
      awayTeamPlayers.Clear();

      homeDataGrid.DataSource = null;
      awayDataGrid.DataSource = null;
      homeDataGrid.Rows.Clear();
      awayDataGrid.Rows.Clear();
      MultipleFiles.Visible = false;

      OT = false;
      multipleFiles = false;
      loadedFile = "";
      homeScore = 0;
      awayScore = 0;

      loadFiles();
      HomeTeam.Text = "Home Team: " + homeScore.ToString();
      AwayTeam.Text = "Away Team: " + awayScore.ToString();
      if (OT) {
        if (homeScore > awayScore) {
          HomeOT.Visible = true;
        }
        else {
          AwayOT.Visible = true;
        }
      }
      MultipleFiles.Visible = multipleFiles;
      LogFileName.Text = loadedFile;
      MultipleFiles.Text = MULTIPLEFILESTEXT;
      if (currentPeriod != "3") {
        MultipleFiles.Text = WRONGPERIODTEXT;
        MultipleFiles.Visible = true;
      }
      homeDataGrid.DataSource = homeTeamPlayers;
      homeDataGrid.DataSource = homeTeamPlayers;
      awayDataGrid.DataSource = awayTeamPlayers;
    }

    static void loadFiles() {
      string[] filePaths = Directory.GetFiles(@".\Logs\", "*.json",
                                         SearchOption.TopDirectoryOnly);

      for (int m = 0; m < filePaths.Length; m++) {
        ParseJson(@filePaths[m]);
        loadedFile += (@filePaths[m] + "   ");
      }
      if (filePaths.Length > 1) {
        multipleFiles = true;
      } else if (filePaths.Length < 1) {
        loadedFile = "Problem Loading File";
      }
    }

    static void ParseJson(string fileName) {
      dynamic o1 = JObject.Parse(File.ReadAllText(fileName));
      if (checkOvertime(o1)) {
        OT = true;
      }
      string homeScoreString = o1.score.home;
      string awayScoreString = o1.score.away;
      homeScore += int.Parse(homeScoreString);
      awayScore += int.Parse(awayScoreString);
      currentPeriod = o1.current_period;
      foreach (dynamic player in o1.players) {
        if (player.team == "home") {
          if (PlayerExists(player, homeTeamPlayers)) {
            for (int p = 0; p < homeTeamPlayers.Count; p++) {
              if (homeTeamPlayers[p].PlayerName == player.username.ToString()) {
                homeTeamPlayers[p].addValues(player);
              }
            }
          }
          else {
            homeTeamPlayers.Add(new stats(player));
          }
        }
        else {
          if (PlayerExists(player, awayTeamPlayers)) {
            for (int p = 0; p < awayTeamPlayers.Count; p++) {
              if (awayTeamPlayers[p].PlayerName == player.username.ToString()) {
                awayTeamPlayers[p].addValues(player);
              }
            }
          }
          else {
            awayTeamPlayers.Add(new stats(player));
          }
        }
      }
      homeTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
      awayTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.PlayerName.CompareTo(c2.PlayerName); });
    }

    static bool checkOvertime(dynamic statsObject) {
      bool returnBool = false;
      double homeTeamOT;
      double awayTeamOT;

      try {
        homeTeamOT = statsObject.players[0].stats.overtime_wins;
      }
      catch {
        homeTeamOT = 0;
      }

      try {
        awayTeamOT = statsObject.players[3].stats.overtime_wins;
      }
      catch {
        awayTeamOT = 0;
      }

      if (awayTeamOT == 1 || homeTeamOT == 1) {
        returnBool = true;
      }
      return returnBool;
    }

    static bool PlayerExists(dynamic passedPlayer, List<stats> playerArray) {
      Boolean returnValue = false;

      for (int j = 0; j < playerArray.Count; j++) {
        if (playerArray[j].PlayerName == passedPlayer.username.ToString()) {
          returnValue = true;
        }
      }
      return returnValue;
    }


  }
}
