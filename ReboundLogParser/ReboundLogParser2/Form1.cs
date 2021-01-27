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
    static string homeScore;
    static string awayScore;
    static bool OT;
    static string loadedFile;
    static bool multipleFiles = false;
    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      loadFiles();
      HomeTeam.Text = "Home Team: " + homeScore;
      AwayTeam.Text = "Away Team: " + awayScore;
      if (OT) {
        if(int.Parse(homeScore) > int.Parse(awayScore)) {
          HomeOT.Visible = true;
        }else {
          AwayOT.Visible = true;
        }
      }
      MultipleFiles.Visible = multipleFiles;
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


      loadFiles();
      HomeTeam.Text = "Home Team: " + homeScore;
      AwayTeam.Text = "Away Team: " + awayScore;
      if (OT) {
        if (int.Parse(homeScore) > int.Parse(awayScore)) {
          HomeOT.Visible = true;
        }
        else {
          AwayOT.Visible = true;
        }
      }
      MultipleFiles.Visible = multipleFiles;
      LogFileName.Text = loadedFile;
      homeDataGrid.DataSource = homeTeamPlayers;
      awayDataGrid.DataSource = awayTeamPlayers;
    }

    static void loadFiles() {
      string[] filePaths = Directory.GetFiles(@".\Logs\", "*.json",
                                         SearchOption.TopDirectoryOnly);
      if(filePaths.Length > 0) {
        ParseJson(@filePaths[0]);
        loadedFile = @filePaths[0];
      }else if (filePaths.Length > 1) {
        multipleFiles = true;
      } else {
        loadedFile = "Problem Loading File";
      }
    }

    static void ParseJson(string fileName) {
      dynamic o1 = JObject.Parse(File.ReadAllText(fileName));
      if (checkOvertime(o1)) {
        OT = true;
      }
      homeScore = o1.score.home;
      awayScore = o1.score.away;
      foreach (dynamic player in o1.players) {
        if (player.team == "home") {
          homeTeamPlayers.Add(new stats(player));
        }
        else {
          awayTeamPlayers.Add(new stats(player));
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

  }
}
