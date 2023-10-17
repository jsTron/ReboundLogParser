using Newtonsoft.Json;
using System.Collections.Generic;

namespace ReboundLogParser
{
    public class Match
    {
        public string Type { get; set; }
        public string Winner { get; set; }
        public string Arena { get; set; }
        [JsonProperty("periods_enabled")]
        public string PeriodsEnabled { get; set; }
        [JsonProperty("current_period")]
        public string CurrentPeriod { get; set; }
        [JsonProperty("custom_mercy_rule")]
        public string CustomMercyRule { get; set; }
        [JsonProperty("match_length")]
        public string MatchLength { get; set; }
        [JsonProperty("end_reason")]
        public string EndReason { get; set; }
        public Score Score { get; set; }
        public List<Player> Players { get; set; }

    }

    public class Score
    {
        public int Home { get; set; }
        public int Away { get; set; }
    }

    public class Player
    {
        [JsonProperty("game_user_id")]
        public string GameUserId { get; set; }
        public string Team { get; set; }
        public Stats Stats { get; set; }
        public string Username { get; set; }
    }

    public class Stats
    {
        // Standard Stats
        public double Goals { get; set; }
        public double Assists { get; set; }
        [JsonProperty("primary_assists")]
        public double PrimaryAssists { get; set; }
        [JsonProperty("secondary_assists")]
        public double SecondaryAssists { get; set; }
        public double Shots { get; set; }
        public double Saves { get; set; }
        [JsonProperty("faceoffs_won")]
        public double FaceoffsWon { get; set; }
        [JsonProperty("faceoffs_lost")]
        public double FaceoffsLost { get; set; }
        public double Takeaways { get; set; }
        public double Turnovers { get; set; }
        [JsonProperty("post_hits")]
        public double PostHits { get; set; }
        public double Passes { get; set; }
        public double Blocks { get; set; }
        [JsonProperty("game_winning_goals")]
        public double GameWinningGoals { get; set; }
        [JsonProperty("possession_time_sec")]
        public double PossessionTimeSec { get; set; }

        // Extended Stats
        [JsonProperty("contributed_goals")]
        public double ContributedGoals { get; set; }
        [JsonProperty("conceded_goals")]
        public double ConcededGoals { get; set; }
        [JsonProperty("games_played")]
        public double GamesPlayed { get; set; }
        public double Wins { get; set; }
        public double Losses { get; set; }
        public double Score { get; set; }
        [JsonProperty("shutouts_against")]
        public double ShutoutsAgainst { get; set; }
        public double Shutouts { get; set; }
        [JsonProperty("overtime_wins")]
        public double OvertimeWins { get; set; }
        [JsonProperty("overtime_losses")]
        public double OvertimeLosses { get; set; }
    }

    public class PlayerStatSums
    {
        public string GameUserId { get; set; }
        public string CurrentPeriod { get; set; }
        public double StatSum { get; set; }
    }
}
