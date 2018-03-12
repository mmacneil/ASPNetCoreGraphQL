
using GraphQL.Types;
using NHLStats.Core.Data;


namespace NHLStats.Api.Models
{
    public class PlayerQuery : ObjectGraphType
    {
        //private IPlayerRepository _playerRepository;

        public PlayerQuery(IPlayerRepository playerRepository)
        {
            Field<PlayerType>(
                "player",
                resolve: context => playerRepository.Get(1)
            );
        }
    }
}
