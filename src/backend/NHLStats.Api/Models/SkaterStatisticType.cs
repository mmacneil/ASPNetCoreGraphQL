 
 
 using GraphQL.Types;
using NHLStats.Core.Models;

namespace NHLStats.Api.Models
{
    public class SkaterStatisticType : ObjectGraphType<SkaterStatistic>
    {
        public SkaterStatisticType()
        {
            Field(x => x.Id).Description("Id");
            Field(x => x.SeasonId).Description("Season id");
            Field(x => x.Season.Name).Name("seasonName").Description("Season name");
            // graphql-dotnet can't currently automatically infer int16 so need to resolve manually
            Field<IntGraphType>("gamesPlayed", resolve: context => context.Source.GamesPlayed,description: "Games played");
        }
    }
}

 
