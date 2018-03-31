 
using Microsoft.EntityFrameworkCore;
using NHLStats.Core.Models;

namespace NHLStats.Data
{
    public sealed class NHLStatsContext : DbContext
    {
        public NHLStatsContext(DbContextOptions options)
            : base(options)
        {
           // Database.EnsureCreated();
           Database.Migrate();
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<SkaterStatistic> SkaterStatistics { get; set; }
        
    }
}
