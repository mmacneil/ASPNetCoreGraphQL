 
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
    }
}
