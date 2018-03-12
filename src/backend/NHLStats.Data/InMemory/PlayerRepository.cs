
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHLStats.Core.Data;
using NHLStats.Core.Models;

namespace NHLStats.Data.InMemory
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly List<Player> _players = new List<Player> {
            new Player() { Id = 1, Name = "R2-D2" }
        };

        public Task<Player> Get(int id)
        {
            return Task.FromResult(_players.FirstOrDefault(droid => droid.Id == id));
        }
    }
}
