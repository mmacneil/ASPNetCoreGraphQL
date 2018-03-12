 
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
                var droid = new Player
                {
                    Name = "R2-D2"
                };
                db.Players.Add(droid);
                db.SaveChanges();
            }
        }
    }
}
