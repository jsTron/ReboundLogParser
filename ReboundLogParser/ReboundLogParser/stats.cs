using System.Collections.Generic;

namespace ReboundLogParser
{
    public class stats
    {
        public stats(Player player)
        {
            PlayerName = player.Username;
            _team = player.Team;
            GameUserId = player.GameUserId;

            try
            {
                Goals = player.Stats.Goals;
            }
            catch
            {
                Goals = 0;
            }

            try
            {
                Assists = player.Stats.Assists;
            }
            catch
            {
                Assists = 0;
            }

            try
            {
                Points = Goals + Assists;
            }
            catch
            {
                Points = 0;
            }

            try
            {
                Primary_assists = player.Stats.PrimaryAssists;
            }
            catch
            {
                Primary_assists = 0;
            }

            try
            {
                Sec_assists = player.Stats.SecondaryAssists;
            }
            catch
            {
                Sec_assists = 0;
            }

            try
            {
                Shots = player.Stats.Shots;
            }
            catch
            {
                Shots = 0;
            }

            try
            {
                Saves = player.Stats.Saves;
            }
            catch
            {
                Saves = 0;
            }

            try
            {
                Faceoffs_won = player.Stats.FaceoffsWon;
            }
            catch
            {
                Faceoffs_won = 0;
            }

            try
            {
                Faceoffs_lost = player.Stats.FaceoffsLost;
            }
            catch
            {
                Faceoffs_lost = 0;
            }

            try
            {
                Takeaways = player.Stats.Takeaways;
            }
            catch
            {
                Takeaways = 0;
            }

            try
            {
                Turnovers = player.Stats.Turnovers;
            }
            catch
            {
                Turnovers = 0;
            }

            try
            {
                Post_hits = player.Stats.PostHits;
            }
            catch
            {
                Post_hits = 0;
            }

            try
            {
                Passes = player.Stats.Passes;
            }
            catch
            {
                Passes = 0;
            }

            try
            {
                Blocks = player.Stats.Blocks;
            }
            catch
            {
                Blocks = 0;
            }

            try
            {
                GW_Goals = player.Stats.GameWinningGoals;
            }
            catch
            {
                GW_Goals = 0;
            }

            try
            {
                Possession_Time = player.Stats.PossessionTimeSec;
            }
            catch
            {
                Possession_Time = 0;
            }
            
            try
            {
                PeriodsPlayed = player.Stats.GamesPlayed;
            }
            catch
            {
                PeriodsPlayed = 0;
            }
        }

        public void addValues(Player player)
        {
            try
            {
                Goals += player.Stats.Goals;
            }
            catch
            {
                Goals += 0;
            }

            try
            {
                Primary_assists += player.Stats.PrimaryAssists;
            }
            catch
            {
                Primary_assists += 0;
            }

            try
            {
                Sec_assists += player.Stats.SecondaryAssists;
            }
            catch
            {
                Sec_assists += 0;
            }

            try
            {
                Shots += player.Stats.Shots;
            }
            catch
            {
                Shots += 0;
            }

            try
            {
                Saves += player.Stats.Saves;
            }
            catch
            {
                Saves += 0;
            }

            try
            {
                Faceoffs_won += player.Stats.FaceoffsWon;
            }
            catch
            {
                Faceoffs_won += 0;
            }

            try
            {
                Faceoffs_lost += player.Stats.FaceoffsLost;
            }
            catch
            {
                Faceoffs_lost += 0;
            }

            try
            {
                Takeaways += player.Stats.Takeaways;
            }
            catch
            {
                Takeaways += 0;
            }

            try
            {
                Turnovers += player.Stats.Turnovers;
            }
            catch
            {
                Turnovers += 0;
            }

            try
            {
                Post_hits += player.Stats.PostHits;
            }
            catch
            {
                Post_hits += 0;
            }

            try
            {
                Passes += player.Stats.Passes;
            }
            catch
            {
                Passes += 0;
            }

            try
            {
                Blocks += player.Stats.Blocks;
            }
            catch
            {
                Blocks += 0;
            }

            try
            {
                GW_Goals += player.Stats.GameWinningGoals;
            }
            catch
            {
                GW_Goals += 0;
            }

            try
            {
                Possession_Time += player.Stats.PossessionTimeSec;
            }
            catch
            {
                Possession_Time += 0;
            }
        }

        public double GetPropertyValueByEnum(StatsEnum enumValue)
        {
            Dictionary<StatsEnum, object> kvp = new Dictionary<StatsEnum, object>()
            {
                { StatsEnum.Goals, Goals },
                { StatsEnum.Assists, Assists },
                { StatsEnum.Points, Points },
                { StatsEnum.PrimaryAssists, Primary_assists },
                { StatsEnum.SecondaryAssists, Sec_assists },
                { StatsEnum.Shots, Shots },
                { StatsEnum.Saves, Saves },
                { StatsEnum.FaceoffsWon, Faceoffs_won },
                { StatsEnum.FaceoffsLost, Faceoffs_lost },
                { StatsEnum.TakeAways, Takeaways },
                { StatsEnum.TurnOvers, Turnovers },
                { StatsEnum.PostHits, Post_hits },
                { StatsEnum.Passes, Passes },
                { StatsEnum.Blocks, Blocks },
                { StatsEnum.GameWinningGoals, GW_Goals },
                { StatsEnum.PossessionTime, Possession_Time },
                { StatsEnum.PeriodsPlayed, PeriodsPlayed },
            };

            return (double)kvp[enumValue];
        }

        public string PlayerName { get; set; }
        public string GameUserId { get; set; }
        public string _team = "away";
        public double Goals { get; set; }
        public double Assists { get; set; }
        public double Points { get; set; }
        public double Primary_assists { get; set; }
        public double Sec_assists { get; set; }
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
        public double Possession_Time { get; set; }
        public double PeriodsPlayed { get; set; }
    }
}
