using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ReboundLogParser {
  class Program {
    static List<stats> homeTeamPlayers = new List<stats>();
    static List<stats> awayTeamPlayers = new List<stats>();

    static void Main(string[] args) {
      Console.SetWindowSize(200, 50);
      Console.Title = "Rebound Log Parser 1.0";

      string[] filePaths = Directory.GetFiles(@".\Logs\", "*.json",
                                         SearchOption.TopDirectoryOnly);

      for (int m = 0; m < filePaths.Length; m++) {
        Console.WriteLine(filePaths[m]);
        Console.WriteLine();
        ParseJson(@filePaths[m]);
        PrintResults();
      }
      Console.Write("Press enter to close");
      Console.ReadLine();
    }

    static void ParseJson(string fileName) {
      dynamic o1 = JObject.Parse(File.ReadAllText(fileName));
      if (checkOvertime(o1)) {
        Console.WriteLine("{0} won the game in Overtime", o1.winner);
      }
      Console.WriteLine("Final Score");
      Console.WriteLine("Home Team: {0} - Away Team: {1}\n", o1.score.home, o1.score.away);
      foreach (dynamic player in o1.players) {
        if (player.team == "home") {
          homeTeamPlayers.Add(new stats(player));
        }
        else {
          awayTeamPlayers.Add(new stats(player));
        }
      }
      homeTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.name.CompareTo(c2.name); });
      awayTeamPlayers.Sort(delegate (stats c1, stats c2) { return c1.name.CompareTo(c2.name); });
    }

    static void PrintResults() {
      Console.WriteLine("Home Team Player Stats\n");
      foreach (stats player in homeTeamPlayers) {
        Console.WriteLine("{0}", player.name);
        Console.WriteLine("Goals   Primary_assists   Secondary_assists   Shots   Saves   Faceoffs_won   Faceoffs_lost   Takeaways   Turnovers   Post_hits   Passes   Blocks   Game_Winning_Goal");
        Console.WriteLine("{0,5}   {1,15}   {2,17}   {3,5}   {4,5}   {5,12}   {6,13}   {7,9}   {8,9}   {9,9}   {10,6}   {11,6}   {12,17}",
          player.Goals, player.Primary_assists, player.Secondary_assists, player.Shots, player.Saves, player.Faceoffs_won, player.Faceoffs_lost, player.Takeaways, player.Turnovers,
          player.Post_hits, player.Passes, player.Blocks, player.game_winning_goals);
        Console.WriteLine();
      }
      Console.WriteLine("\nAway Team Player Stats\n");
      foreach (stats player in awayTeamPlayers) {
        Console.WriteLine("{0}", player.name);
        Console.WriteLine("Goals   Primary_assists   Secondary_assists   Shots   Saves   Faceoffs_won   Faceoffs_lost   Takeaways   Turnovers   Post_hits   Passes   Blocks   Game_Winning_Goal");
        Console.WriteLine("{0,5}   {1,15}   {2,17}   {3,5}   {4,5}   {5,12}   {6,13}   {7,9}   {8,9}   {9,9}   {10,6}   {11,6}   {12,17}",
          player.Goals, player.Primary_assists, player.Secondary_assists, player.Shots, player.Saves, player.Faceoffs_won, player.Faceoffs_lost, player.Takeaways, player.Turnovers,
          player.Post_hits, player.Passes, player.Blocks, player.game_winning_goals);
        Console.WriteLine();
      }
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
