 
using System;
using System.Collections.Generic;
using System.Linq;
using NHLStats.Core.Models;

namespace NHLStats.Data
{
    public static class NHLStatsSeedData
    {
        private const string RegularSeason20142015 = "2014-2015 Regular Season";
        private const string RegularSeason20152016 = "2015-2016 Regular Season";
        private const string RegularSeason20162017 = "2016-2017 Regular Season";
        private const string RegularSeason20172018 = "2017-2018 Regular Season";
        private const string Playoffs20142015 = "2014-2015 Playoffs";
        private const string Playoffs20152016 = "2015-2016 Playoffs";
        private const string Playoffs20162017 = "2016-2017 Playoffs";
        private const string Playoffs20172018 = "2017-2018 Playoffs";

        public static void EnsureSeedData(this NHLStatsContext db)
        {
            if (!db.Players.Any())
            {
                var players = new List<Player>
                {
                   new Player { Name = "Sidney Crosby",  BirthDate = new DateTime(1987,8,7), Height = "5'11",WeightLbs = 200},
                   new Player { Name = "Connor McDavid", BirthDate = new DateTime(1997,1,13), Height = "6'01",WeightLbs = 192},
                   new Player { Name = "Alex Ovechkin",  BirthDate = new DateTime(1985,1,13), Height = "6'03",WeightLbs = 235}
                };
                db.Players.AddRange(players);
                db.SaveChanges();
            }

            if (!db.Seasons.Any())
            {
                var seasons = new List<Season>
                {
                    new Season {Name = RegularSeason20142015},
                    new Season {Name = RegularSeason20152016},
                    new Season {Name = RegularSeason20162017},
                    new Season {Name = RegularSeason20172018},
                    new Season {Name = Playoffs20142015},
                    new Season {Name = Playoffs20152016},
                    new Season {Name = Playoffs20162017},
                    new Season {Name = Playoffs20172018}
                };
                db.Seasons.AddRange(seasons);
                db.SaveChanges();
            }

            if (!db.Teams.Any())
            {
                var teams = new List<Team>
                {
                    new Team {Name = "Edmonton Oilers", Abbreviation = "EDM"},
                    new Team {Name = "Washington Capitals", Abbreviation = "WAS"},
                    new Team {Name = "Pittsburgh Penguins", Abbreviation = "PIT"}
                };
                db.Teams.AddRange(teams);
                db.SaveChanges();
            }

            if (!db.Leagues.Any())
            {
                var leagues = new List<League>
                {
                    new League { Name = "National Hockey League", Abbreviation = "NHL" },
                    new League { Name = "Kontinental Hockey League", Abbreviation = "KHL" },
                };
                db.Leagues.AddRange(leagues);
                db.SaveChanges();
            }

            if (!db.SkaterStatistics.Any())
            {
                var nhl = db.Leagues.Single(l => l.Abbreviation == "NHL");
                var regularSeason20152016 = db.Seasons.Single(s => s.Name == RegularSeason20152016);
                var regularSeason20162017 = db.Seasons.Single(s => s.Name == RegularSeason20162017);
                var regularSeason20172018 = db.Seasons.Single(s => s.Name == RegularSeason20172018);
                var playoffs20162017 = db.Seasons.Single(s => s.Name == Playoffs20162017);
                var cMcDavid = db.Players.Single(p => p.Name == "Connor McDavid");

                var cMcDavidSeasonStatRegularSeason20152016 = new SkaterStatistic
                {
                    SeasonId = regularSeason20152016.Id,
                    LeagueId = nhl.Id,
                    PlayerId = cMcDavid.Id,
                    GamesPlayed = 45,
                    Goals = 16, 
                    Assists = 32, 
                    Points = 48,
                    PenaltyMinutes = 18,
                    PlusMinus = -1
                };

                var cMcDavidSeasonStatRegularSeason20162017 = new SkaterStatistic
                {
                    SeasonId = regularSeason20162017.Id,
                    LeagueId = nhl.Id,
                    PlayerId = cMcDavid.Id,
                    GamesPlayed = 82,
                    Goals = 30,
                    Assists = 70,
                    Points = 100,
                    PenaltyMinutes = 26,
                    PlusMinus = 27
                };

                var cMcDavidSeasonStatPlayoffs20162017 = new SkaterStatistic
                {
                    SeasonId = playoffs20162017.Id,
                    LeagueId = nhl.Id,
                    PlayerId = cMcDavid.Id,
                    GamesPlayed = 13,
                    Goals = 5,
                    Assists = 4,
                    Points = 9,
                    PenaltyMinutes = 2
                };

                var cMcDavidSeasonStatRegularSeason20172018 = new SkaterStatistic
                {
                    SeasonId = regularSeason20172018.Id,
                    LeagueId = nhl.Id,
                    PlayerId = cMcDavid.Id,
                    GamesPlayed = 68,
                    Goals = 33,
                    Assists = 51,
                    Points = 84,
                    PenaltyMinutes = 26,
                    PlusMinus = 16
                };

                db.SkaterStatistics.Add(cMcDavidSeasonStatRegularSeason20152016);
                db.SkaterStatistics.Add(cMcDavidSeasonStatRegularSeason20162017);
                db.SkaterStatistics.Add(cMcDavidSeasonStatPlayoffs20162017);
                db.SkaterStatistics.Add(cMcDavidSeasonStatRegularSeason20172018);
                db.SaveChanges();
            }
        }
    }
}
