
using GraphQL.Types;
using NHLStats.Core.Models;

namespace NHLStats.Api.Models
{
    public class PlayerQuery : ObjectGraphType
    {
        public PlayerQuery()
        {
            Field<PlayerType>(
                "player",
                resolve: context => new Player { Id = 1, Name = "Sidney Crosby" }
            );
        }
    }
}
