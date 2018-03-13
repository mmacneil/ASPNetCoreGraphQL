 
using System;
using System.Collections.Generic;
using System.Linq;
using NHLStats.Core.Models;

namespace NHLStats.Data
{
    public static class NHLStatsSeedData
    {
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
            }

            if (!db.Seasons.Any())
            {
                var seasons = new List<Season>
                {
                    new Season {Name = "2014-2015"},
                    new Season {Name = "2015-2016"},
                    new Season {Name = "2016-2017"}
                };
                db.Seasons.AddRange(seasons);
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
            }

            if (!db.Leagues.Any())
            {
                var leagues = new List<League>
                {
                    new League { Name = "National Hockey League", Abbreviation = "NHL" },
                    new League { Name = "Kontinental Hockey League", Abbreviation = "KHL" },
                };
                db.Leagues.AddRange(leagues);
            }

            db.SaveChanges();
        }
    }
}
