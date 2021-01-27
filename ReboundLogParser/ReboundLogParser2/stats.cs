using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReboundLogParser2 {
  class stats
  {
    

    public stats(dynamic statsObject)
    {
      PlayerName = statsObject.username;
      team = statsObject.team;
      try {
        Goals = statsObject.stats.goals.Value;
      }
      catch {
        Goals = 0;
      }

      try {
        Primary_assists = statsObject.stats.primary_assists.Value;
      }
      catch {
        Primary_assists = 0;
      }

      try {
        Sec_assists = statsObject.stats.secondary_assists.Value;
      }
      catch {
        Sec_assists = 0;
      }

      try {
        Assists = statsObject.stats.assists.Value;
      }
      catch {
        Assists = 0;
      }

      try {
        Shots = statsObject.stats.shots.Value;
      }
      catch {
        Shots = 0;
      }

      try {
        Saves = statsObject.stats.saves.Value;
      }
      catch {
        Saves = 0;
      }

      try {
        Faceoffs_won = statsObject.stats.faceoffs_won.Value;
      }
      catch {
        Faceoffs_won = 0;
      }

      try {
        Faceoffs_lost = statsObject.stats.faceoffs_lost.Value;
      }
      catch {
        Faceoffs_lost = 0;
      }

      try {
        Takeaways = statsObject.stats.takeaways.Value;
      }
      catch {
        Takeaways = 0;
      }

      try {
        Turnovers = statsObject.stats.turnovers.Value;
      }

      catch {
        Turnovers = 0;
      }
      try {
        Post_hits = statsObject.stats.post_hits.Value;
      }

      catch {
        Post_hits = 0;
      }

      try {
        Passes = statsObject.stats.passes.Value;
      }
      catch {
        Passes = 0;
      }

      try {
        Blocks = statsObject.stats.blocks.Value;
      }
      catch {
        Blocks = 0;
      }

      try {
        GW_Goals = statsObject.stats.game_winning_goals.Value;
      }
      catch {
        GW_Goals = 0;
      }
    }

    public string PlayerName { get; set; }
    public string team;
    public double Goals { get; set; }
    public double Primary_assists { get; set; }
    public double Sec_assists { get; set; }
    public double Assists { get; set; }
    public double Shots { get; set; }
    public double Saves { get; set; }
    public double Faceoffs_won { get; set; }
    public double Faceoffs_lost { get; set; }
    public double Takeaways { get; set; }
    public double Turnovers { get; set; }
    public double Post_hits { get; set; }
    public double Passes { get; set; }
    public double Blocks { get; set; }
    public double GW_Goals { get; set; }
  }
}
