
 
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NHLStats.Core.Data;
using NHLStats.Core.Models;

namespace NHLStats.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly NHLStatsContext _db;

        public PlayerRepository(NHLStatsContext db)
        {
            _db = db;
        }

        public async Task<Player> Get(int id)
        {
            return await _db.Players.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Player>> All()
        {
            return await _db.Players.ToListAsync();
        }
    }
}
