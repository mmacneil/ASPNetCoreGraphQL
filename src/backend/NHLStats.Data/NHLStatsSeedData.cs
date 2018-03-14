 
using System;
using System.Collections.Generic;
using System.Linq;
using NHLStats.Core.Models;

namespace NHLStats.Data
{
    public static class NHLStatsSeedData
    {
        private const string RegularSeason20052006 = "2005-2006 Regular Season";
        private const string RegularSeason20062007 = "2006-2007 Regular Season";
        private const string RegularSeason20072008 = "2007-2008 Regular Season";
        private const string RegularSeason20082009 = "2008-2009 Regular Season";
        private const string RegularSeason20092010 = "2009-2010 Regular Season";
        private const string RegularSeason20102011 = "2010-2011 Regular Season";
        private const string RegularSeason20112012 = "2011-2012 Regular Season";
        private const string RegularSeason20122013 = "2012-2013 Regular Season";
        private const string RegularSeason20132014 = "2013-2014 Regular Season";
        private const string RegularSeason20142015 = "2014-2015 Regular Season";
        private const string RegularSeason20152016 = "2015-2016 Regular Season";
        private const string RegularSeason20162017 = "2016-2017 Regular Season";
        private const string RegularSeason20172018 = "2017-2018 Regular Season";
        private const string Playoffs20052006 = "2005-2006 Playoffs";
        private const string Playoffs20062007 = "2006-2007 Playoffs";
        private const string Playoffs20072008 = "2007-2008 Playoffs";
        private const string Playoffs20082009 = "2008-2009 Playoffs";
        private const string Playoffs20092010 = "2009-2010 Playoffs";
        private const string Playoffs20102011 = "2010-2011 Playoffs";
        private const string Playoffs20112012 = "2011-2012 Playoffs";
        private const string Playoffs20122013 = "2012-2013 Playoffs";
        private const string Playoffs20132014 = "2013-2014 Playoffs";
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
                   new Player { Name = "Sidney Crosby",  BirthDate = new DateTime(1987,8,7), Height = "5'11",WeightLbs = 200, BirthPlace = "Cole Harbour, NS"},
                   new Player { Name = "Connor McDavid", BirthDate = new DateTime(1997,1,13), Height = "6'01",WeightLbs = 192, BirthPlace = "Richmond Hill, ONT"},
                   new Player { Name = "Alex Ovechkin",  BirthDate = new DateTime(1985,1,13), Height = "6'03",WeightLbs = 235, BirthPlace = "Moscow, Russia"}
                };
                db.Players.AddRange(players);
                db.SaveChanges();
            }

            if (!db.Seasons.Any())
            {
                var seasons = new List<Season>
                {
                    new Season {Name = RegularSeason20052006},
                    new Season {Name = RegularSeason20062007},
                    new Season {Name = RegularSeason20072008},
                    new Season {Name = RegularSeason20082009},
                    new Season {Name = RegularSeason20092010},
                    new Season {Name = RegularSeason20102011},
                    new Season {Name = RegularSeason20112012},
                    new Season {Name = RegularSeason20122013},
                    new Season {Name = RegularSeason20132014},
                    new Season {Name = RegularSeason20142015},
                    new Season {Name = RegularSeason20152016},
                    new Season {Name = RegularSeason20162017},
                    new Season {Name = RegularSeason20172018},
                    new Season {Name = Playoffs20052006},
                    new Season {Name = Playoffs20062007},
                    new Season {Name = Playoffs20072008},
                    new Season {Name = Playoffs20082009},
                    new Season {Name = Playoffs20092010},
                    new Season {Name = Playoffs20102011},
                    new Season {Name = Playoffs20112012},
                    new Season {Name = Playoffs20122013},
                    new Season {Name = Playoffs20132014},
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
                    new Team {Name = "Pittsburgh Penguins", Abbreviation = "PIT"},
                    new Team {Name = "Moscow Dynamo", Abbreviation = "Dynamo"}
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
                var khl = db.Leagues.Single(l => l.Abbreviation == "KHL");
                var regularSeason20052006 = db.Seasons.Single(s => s.Name == RegularSeason20052006);
                var regularSeason20062007 = db.Seasons.Single(s => s.Name == RegularSeason20062007);
                var regularSeason20072008 = db.Seasons.Single(s => s.Name == RegularSeason20072008);
                var regularSeason20082009 = db.Seasons.Single(s => s.Name == RegularSeason20082009);
                var regularSeason20092010 = db.Seasons.Single(s => s.Name == RegularSeason20092010);
                var regularSeason20102011 = db.Seasons.Single(s => s.Name == RegularSeason20102011);
                var regularSeason20112012 = db.Seasons.Single(s => s.Name == RegularSeason20112012);
                var regularSeason20122013 = db.Seasons.Single(s => s.Name == RegularSeason20122013);
                var regularSeason20132014 = db.Seasons.Single(s => s.Name == RegularSeason20132014);
                var regularSeason20142015 = db.Seasons.Single(s => s.Name == RegularSeason20142015);
                var regularSeason20152016 = db.Seasons.Single(s => s.Name == RegularSeason20152016);
                var regularSeason20162017 = db.Seasons.Single(s => s.Name == RegularSeason20162017);
                var regularSeason20172018 = db.Seasons.Single(s => s.Name == RegularSeason20172018);
                var playoffs20062007 = db.Seasons.Single(s => s.Name == Playoffs20062007);
                var playoffs20072008 = db.Seasons.Single(s => s.Name == Playoffs20072008);
                var playoffs20082009 = db.Seasons.Single(s => s.Name == Playoffs20082009);
                var playoffs20092010 = db.Seasons.Single(s => s.Name == Playoffs20092010);
                var playoffs20102011 = db.Seasons.Single(s => s.Name == Playoffs20102011);
                var playoffs20112012 = db.Seasons.Single(s => s.Name == Playoffs20112012);
                var playoffs20122013 = db.Seasons.Single(s => s.Name == Playoffs20122013);
                var playoffs20132014 = db.Seasons.Single(s => s.Name == Playoffs20132014);
                var playoffs20142015 = db.Seasons.Single(s => s.Name == Playoffs20142015);
                var playoffs20152016 = db.Seasons.Single(s => s.Name == Playoffs20142015);
                var playoffs20162017 = db.Seasons.Single(s => s.Name == Playoffs20162017);
                var cMcDavid = db.Players.Single(p => p.Name == "Connor McDavid");
                var sCrosby = db.Players.Single(p => p.Name == "Sidney Crosby");
                var aOvechkin = db.Players.Single(p => p.Name == "Alex Ovechkin");
                var oilers = db.Teams.Single(t => t.Abbreviation == "EDM");
                var penguins = db.Teams.Single(t => t.Abbreviation == "PIT");
                var capitals = db.Teams.Single(t => t.Abbreviation == "WAS");
                var dynamo = db.Teams.Single(t => t.Abbreviation == "Dynamo");



                var aOvechkinSeasonStatRegularSeason20052006 = new SkaterStatistic
                {
                    SeasonId = regularSeason20052006.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 81,
                    Goals = 52,
                    Assists = 54,
                    Points = 106,
                    PenaltyMinutes = 52,
                    PlusMinus = 2
                };

               
                var aOvechkinSeasonStatRegularSeason20062007 = new SkaterStatistic
                {
                    SeasonId = regularSeason20062007.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 82,
                    Goals = 46,
                    Assists = 46,
                    Points = 92,
                    PenaltyMinutes = 52,
                    PlusMinus = -19
                };

                var aOvechkinSeasonStatRegularSeason20072008 = new SkaterStatistic
                {
                    SeasonId = regularSeason20072008.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 82,
                    Goals = 65,
                    Assists = 47,
                    Points = 112,
                    PenaltyMinutes = 40,
                    PlusMinus = 28
                };
                var aOvechkinSeasonStatPlayoffs20072008 = new SkaterStatistic
                {
                    SeasonId = playoffs20072008.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 7,
                    Goals = 4,
                    Assists = 5,
                    Points = 9,
                    PenaltyMinutes = 0
                };

                var aOvechkinSeasonStatRegularSeason20082009 = new SkaterStatistic
                {
                    SeasonId = regularSeason20082009.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 79,
                    Goals = 56,
                    Assists = 54,
                    Points = 110,
                    PenaltyMinutes = 72,
                    PlusMinus = 8
                };

                var aOvechkinSeasonStatPlayoffs20082009 = new SkaterStatistic
                {
                    SeasonId = playoffs20082009.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 14,
                    Goals = 11,
                    Assists = 10,
                    Points = 21,
                    PenaltyMinutes = 8
                };

                var aOvechkinSeasonStatRegularSeason20092010 = new SkaterStatistic
                {
                    SeasonId = regularSeason20092010.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 72,
                    Goals = 50,
                    Assists = 59,
                    Points = 109,
                    PenaltyMinutes = 89,
                    PlusMinus = 45
                };

                var aOvechkinSeasonStatPlayoffs20092010 = new SkaterStatistic
                {
                    SeasonId = playoffs20092010.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 7,
                    Goals = 5,
                    Assists = 5,
                    Points = 10,
                    PenaltyMinutes = 0
                };

                var aOvechkinSeasonStatRegularSeason20102011 = new SkaterStatistic
                {
                    SeasonId = regularSeason20102011.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 79,
                    Goals = 32,
                    Assists = 53,
                    Points = 85,
                    PenaltyMinutes = 41,
                    PlusMinus = 24
                };

                var aOvechkinSeasonStatPlayoffs20102011 = new SkaterStatistic
                {
                    SeasonId = playoffs20102011.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 9,
                    Goals = 5,
                    Assists = 5,
                    Points = 10,
                    PenaltyMinutes = 10
                };

                var aOvechkinSeasonStatRegularSeason20112012 = new SkaterStatistic
                {
                    SeasonId = regularSeason20112012.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 78,
                    Goals = 38,
                    Assists = 27,
                    Points = 65,
                    PenaltyMinutes = 26,
                    PlusMinus = -8
                };

                var aOvechkinSeasonStatPlayoffs20112012 = new SkaterStatistic
                {
                    SeasonId = playoffs20112012.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 14,
                    Goals = 5,
                    Assists = 4,
                    Points = 9,
                    PenaltyMinutes = 8
                };

                var aOvechkinSeasonStatRegularSeason20122013 = new SkaterStatistic
                {
                    SeasonId = regularSeason20122013.Id,
                    LeagueId = khl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = dynamo.Id,
                    GamesPlayed = 31,
                    Goals = 19,
                    Assists = 21,
                    Points = 40,
                    PenaltyMinutes = 14,
                    PlusMinus = 13
                };

                var aOvechkinSeasonStatRegularSeason20122013NHL = new SkaterStatistic
                {
                    SeasonId = regularSeason20122013.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 48,
                    Goals = 32,
                    Assists = 24,
                    Points = 56,
                    PenaltyMinutes = 36,
                    PlusMinus = 2
                };

                var aOvechkinSeasonStatPlayoffs20122013 = new SkaterStatistic
                {
                    SeasonId = playoffs20122013.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 7,
                    Goals = 1,
                    Assists = 1,
                    Points = 2,
                    PenaltyMinutes = 4
                };
                
                var aOvechkinSeasonStatRegularSeason20132014 = new SkaterStatistic
                {
                    SeasonId = regularSeason20132014.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 78,
                    Goals = 51,
                    Assists = 28,
                    Points = 79,
                    PenaltyMinutes = 48,
                    PlusMinus = -35
                };

             

                var aOvechkinSeasonStatRegularSeason20142015 = new SkaterStatistic
                {
                    SeasonId = regularSeason20142015.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 81,
                    Goals = 53,
                    Assists = 28,
                    Points = 81,
                    PenaltyMinutes = 58,
                    PlusMinus = 10
                };

                var aOvechkinSeasonStatPlayoffs20142015 = new SkaterStatistic
                {
                    SeasonId = playoffs20142015.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 14,
                    Goals = 5,
                    Assists = 4,
                    Points = 9,
                    PenaltyMinutes = 6
                };


                
                var aOvechkinSeasonStatRegularSeason20152016 = new SkaterStatistic
                {
                    SeasonId = regularSeason20152016.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 79,
                    Goals = 50,
                    Assists = 21,
                    Points = 71,
                    PenaltyMinutes = 53,
                    PlusMinus = 21
                };

                var aOvechkinSeasonStatPlayoffs20152016 = new SkaterStatistic
                {
                    SeasonId = playoffs20152016.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 12,
                    Goals = 5,
                    Assists = 7,
                    Points = 12,
                    PenaltyMinutes = 2
                };

                var aOvechkinSeasonStatRegularSeason20162017 = new SkaterStatistic
                {
                    SeasonId = regularSeason20162017.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 82,
                    Goals = 33,
                    Assists = 36,
                    Points = 69,
                    PenaltyMinutes = 50,
                    PlusMinus = 6
                };

                var aOvechkinSeasonStatPlayoffs20162017 = new SkaterStatistic
                {
                    SeasonId = playoffs20162017.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 13,
                    Goals = 5,
                    Assists = 3,
                    Points = 8,
                    PenaltyMinutes = 8
                };

              
                var aOvechkinSeasonStatRegularSeason20172018 = new SkaterStatistic
                {
                    SeasonId = regularSeason20172018.Id,
                    LeagueId = nhl.Id,
                    PlayerId = aOvechkin.Id,
                    TeamId = capitals.Id,
                    GamesPlayed = 69,
                    Goals = 42,
                    Assists = 32,
                    Points = 74,
                    PenaltyMinutes = 24,
                    PlusMinus = 2
                };


                var sCrosbySeasonStatRegularSeason20052006 = new SkaterStatistic
                {
                    SeasonId = regularSeason20052006.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 81,
                    Goals = 39,
                    Assists = 63,
                    Points = 102,
                    PenaltyMinutes = 110,
                    PlusMinus = -1
                };

                var sCrosbySeasonStatRegularSeason20062007 = new SkaterStatistic
                {
                    SeasonId = regularSeason20062007.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 79,
                    Goals = 36,
                    Assists = 84,
                    Points = 120,
                    PenaltyMinutes = 60,
                    PlusMinus = 10
                };

                var sCrosbySeasonStatRegularSeason20072008 = new SkaterStatistic
                {
                    SeasonId = regularSeason20072008.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 53,
                    Goals = 24,
                    Assists = 48,
                    Points = 72,
                    PenaltyMinutes = 39,
                    PlusMinus = 18
                };

                var sCrosbySeasonStatRegularSeason20082009 = new SkaterStatistic
                {
                    SeasonId = regularSeason20082009.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 77,
                    Goals = 33,
                    Assists = 70,
                    Points = 103,
                    PenaltyMinutes = 76,
                    PlusMinus = 3
                };

                var sCrosbySeasonStatRegularSeason20092010 = new SkaterStatistic
                {
                    SeasonId = regularSeason20092010.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 81,
                    Goals = 51,
                    Assists = 58,
                    Points = 109,
                    PenaltyMinutes = 71,
                    PlusMinus = 15
                };

                var sCrosbySeasonStatRegularSeason20102011 = new SkaterStatistic
                {
                    SeasonId = regularSeason20102011.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 41,
                    Goals = 32,
                    Assists = 34,
                    Points = 66,
                    PenaltyMinutes = 31,
                    PlusMinus = 20
                };

                var sCrosbySeasonStatRegularSeason20112012 = new SkaterStatistic
                {
                    SeasonId = regularSeason20112012.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 41,
                    Goals = 22,
                    Assists = 29,
                    Points = 37,
                    PenaltyMinutes = 14,
                    PlusMinus = 15
                };

                var sCrosbySeasonStatRegularSeason20122013 = new SkaterStatistic
                {
                    SeasonId = regularSeason20122013.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 36,
                    Goals = 15,
                    Assists = 41,
                    Points = 56,
                    PenaltyMinutes = 16,
                    PlusMinus = 26
                };

                var sCrosbySeasonStatRegularSeason20132014 = new SkaterStatistic
                {
                    SeasonId = regularSeason20132014.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 80,
                    Goals = 36,
                    Assists = 68,
                    Points = 104,
                    PenaltyMinutes = 46,
                    PlusMinus = 18
                };

                var sCrosbySeasonStatRegularSeason20142015 = new SkaterStatistic
                {
                    SeasonId = regularSeason20142015.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 77,
                    Goals = 28,
                    Assists = 56,
                    Points = 84,
                    PenaltyMinutes = 47,
                    PlusMinus = 5
                };

                var sCrosbySeasonStatRegularSeason20152016 = new SkaterStatistic
                {
                    SeasonId = regularSeason20152016.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 80,
                    Goals = 36,
                    Assists = 49,
                    Points = 85,
                    PenaltyMinutes = 42,
                    PlusMinus = 19
                };

                var sCrosbySeasonStatRegularSeason20162017 = new SkaterStatistic
                {
                    SeasonId = regularSeason20162017.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 75,
                    Goals = 44,
                    Assists = 45,
                    Points = 89,
                    PenaltyMinutes = 24,
                    PlusMinus = 17
                };

                var sCrosbySeasonStatRegularSeason20172018 = new SkaterStatistic
                {
                    SeasonId = regularSeason20172018.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 70,
                    Goals = 23,
                    Assists = 53,
                    Points = 76,
                    PenaltyMinutes = 44,
                    PlusMinus = 0
                };

                var sCrosbySeasonStatPlayoffs20062007 = new SkaterStatistic
                {
                    SeasonId = playoffs20062007.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 5,
                    Goals = 3,
                    Assists = 2,
                    Points = 5,
                    PenaltyMinutes = 4
                };

                var sCrosbySeasonStatPlayoffs20072008 = new SkaterStatistic
                {
                    SeasonId = playoffs20072008.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 20,
                    Goals = 6,
                    Assists = 21,
                    Points = 27,
                    PenaltyMinutes = 12
                };

                var sCrosbySeasonStatPlayoffs20082009 = new SkaterStatistic
                {
                    SeasonId = playoffs20082009.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 24,
                    Goals = 15,
                    Assists = 16,
                    Points = 31,
                    PenaltyMinutes = 14
                };

                var sCrosbySeasonStatPlayoffs20092010 = new SkaterStatistic
                {
                    SeasonId = playoffs20092010.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 13,
                    Goals = 6,
                    Assists = 13,
                    Points = 19,
                    PenaltyMinutes = 6
                };

                var sCrosbySeasonStatPlayoffs20112012 = new SkaterStatistic
                {
                    SeasonId = playoffs20112012.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 6,
                    Goals = 3,
                    Assists = 5,
                    Points = 8,
                    PenaltyMinutes = 9
                };

                var sCrosbySeasonStatPlayoffs20122013 = new SkaterStatistic
                {
                    SeasonId = playoffs20122013.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 14,
                    Goals = 7,
                    Assists = 8,
                    Points = 15,
                    PenaltyMinutes = 8
                };

                var sCrosbySeasonStatPlayoffs20132014 = new SkaterStatistic
                {
                    SeasonId = playoffs20132014.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 13,
                    Goals = 1,
                    Assists = 8,
                    Points = 9,
                    PenaltyMinutes = 4
                };

                var sCrosbySeasonStatPlayoffs20142015 = new SkaterStatistic
                {
                    SeasonId = playoffs20142015.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 5,
                    Goals = 2,
                    Assists = 2,
                    Points = 4,
                    PenaltyMinutes = 0
                };

                var sCrosbySeasonStatPlayoffs20152016 = new SkaterStatistic
                {
                    SeasonId = playoffs20152016.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 24,
                    Goals = 6,
                    Assists = 13,
                    Points = 19,
                    PenaltyMinutes = 4
                };

                var sCrosbySeasonStatPlayoffs20162017 = new SkaterStatistic
                {
                    SeasonId = playoffs20162017.Id,
                    LeagueId = nhl.Id,
                    PlayerId = sCrosby.Id,
                    TeamId = penguins.Id,
                    GamesPlayed = 24,
                    Goals = 8,
                    Assists = 19,
                    Points = 27,
                    PenaltyMinutes = 10
                };

                var cMcDavidSeasonStatRegularSeason20152016 = new SkaterStatistic
                {
                    SeasonId = regularSeason20152016.Id,
                    LeagueId = nhl.Id,
                    PlayerId = cMcDavid.Id,
                    TeamId = oilers.Id,
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
                    TeamId = oilers.Id,
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
                    TeamId = oilers.Id,
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
                    TeamId = oilers.Id,
                    GamesPlayed = 68,
                    Goals = 33,
                    Assists = 51,
                    Points = 84,
                    PenaltyMinutes = 26,
                    PlusMinus = 16
                };

                
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20052006);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20062007);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20072008);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20082009);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20092010);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20102011);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20112012);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20122013);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20122013NHL);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20132014);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20142015);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20152016);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20162017);
                db.SkaterStatistics.Add(aOvechkinSeasonStatRegularSeason20172018);

                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20072008);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20082009);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20092010);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20102011);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20112012);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20122013);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20142015);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20152016);
                db.SkaterStatistics.Add(aOvechkinSeasonStatPlayoffs20162017);




                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20052006);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20062007);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20072008);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20082009);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20092010);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20102011);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20112012);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20122013);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20132014);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20142015);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20152016);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20162017);
                db.SkaterStatistics.Add(sCrosbySeasonStatRegularSeason20172018);

                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20062007);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20072008);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20082009);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20092010);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20112012);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20122013);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20132014);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20142015);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20152016);
                db.SkaterStatistics.Add(sCrosbySeasonStatPlayoffs20162017);


                db.SkaterStatistics.Add(cMcDavidSeasonStatRegularSeason20152016);
                db.SkaterStatistics.Add(cMcDavidSeasonStatRegularSeason20162017);
                db.SkaterStatistics.Add(cMcDavidSeasonStatPlayoffs20162017);
                db.SkaterStatistics.Add(cMcDavidSeasonStatRegularSeason20172018);
                db.SaveChanges();
            }
        }
    }
}
