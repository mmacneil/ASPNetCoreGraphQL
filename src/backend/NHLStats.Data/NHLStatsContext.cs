 
using Microsoft.EntityFrameworkCore;
using NHLStats.Core.Models;

namespace NHLStats.Data
{
    public class NHLStatsContext : DbContext
    {
        public NHLStatsContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}
