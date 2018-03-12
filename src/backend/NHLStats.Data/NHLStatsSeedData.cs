 
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
                var player = new Player
                {
                    Name = "Sidney Crosby"
                };
                db.Players.Add(player);
                db.SaveChanges();
            }
        }
    }
}
