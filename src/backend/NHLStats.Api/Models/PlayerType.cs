
using GraphQL.Types;
using NHLStats.Core.Data;
using NHLStats.Core.Models;

namespace NHLStats.Api.Models
{
    public class PlayerType : ObjectGraphType<Player>
    {
        public PlayerType(ISkaterStatisticRepository skaterStatisticRepository)
        {
            Field(x => x.Id).Description("The id of the player");
            Field(x => x.Name, true).Description("The name of the player");
            Field<ListGraphType<SkaterStatisticType>>("skaterSeasonStats",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => skaterStatisticRepository.Get(context.GetArgument<int>("id")),description: "Player's skater stats");
        }
    }
}
