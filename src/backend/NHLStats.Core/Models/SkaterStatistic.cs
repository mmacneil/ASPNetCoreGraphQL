 

namespace NHLStats.Core.Models
{
    public class SkaterStatistic
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public int LeagueId { get; set; }
        public int PlayerId { get; set; }
        public ushort GamesPlayed { get; set; }
        public ushort Goals { get; set; }
        public ushort Assists { get; set; }
        public ushort Points { get; set; }
        public ushort PenaltyMinutes { get; set; }
        public short? PlusMinus { get; set; }

        public virtual Season Season { get; set; }
        public virtual League League { get; set; }
    }
}
