
using GraphQL.Types;
using NHLStats.Core.Data;


namespace NHLStats.Api.Models
{
    public class NHLStatsQuery : ObjectGraphType
    {
        public NHLStatsQuery(IPlayerRepository playerRepository)
        {
            Field<PlayerType>(
                "player",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => playerRepository.Get(context.GetArgument<int>("id")));

            Field<ListGraphType<PlayerType>>(
                "players",
                resolve: context => playerRepository.All());
        }
    }
}


 