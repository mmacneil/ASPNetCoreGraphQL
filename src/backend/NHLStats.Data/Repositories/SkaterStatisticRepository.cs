
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NHLStats.Core.Data;
using NHLStats.Core.Models;

namespace NHLStats.Data.Repositories
{
    public class SkaterStatisticRepository : ISkaterStatisticRepository
    {
        private readonly NHLStatsContext _db;

        public SkaterStatisticRepository(NHLStatsContext db)
        {
            _db = db;
        }

        public async Task<List<SkaterStatistic>> Get(int playerId)
        {
            return await _db.SkaterStatistics.Include(ss=>ss.Season).Include(ss=>ss.League).Include(ss=>ss.Team).Where(ss => ss.PlayerId == playerId).ToListAsync();
        }
    }
}
