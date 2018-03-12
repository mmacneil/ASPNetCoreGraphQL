
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NHLStats.Core.Data;
using NHLStats.Core.Models;

namespace NHLStats.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private NHLStatsContext _db { get; set; }

        public PlayerRepository(NHLStatsContext db)
        {
            _db = db;
        }

        public Task<Player> Get(int id)
        {
            return _db.Players.FirstOrDefaultAsync(droid => droid.Id == id);
        }
    }
}
