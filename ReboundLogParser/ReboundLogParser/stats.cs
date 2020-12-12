using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReboundLogParser
{
  class stats
  {
    

    public stats(dynamic statsObject)
    {
      name = statsObject.username;
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
        Secondary_assists = statsObject.stats.secondary_assists.Value;
      }
      catch {
        Secondary_assists = 0;
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
        game_winning_goals = statsObject.stats.game_winning_goals.Value;
      }
      catch {
        game_winning_goals = 0;
      }
    }

    public string name;
    public string team;
    public double Goals;
    public double Primary_assists;
    public double Secondary_assists;
    public double Assists;
    public double Shots;
    public double Saves;
    public double Faceoffs_won;
    public double Faceoffs_lost;
    public double Takeaways;
    public double Turnovers;
    public double Post_hits;
    public double Passes;
    public double Blocks;
    public double game_winning_goals;
  }
}
