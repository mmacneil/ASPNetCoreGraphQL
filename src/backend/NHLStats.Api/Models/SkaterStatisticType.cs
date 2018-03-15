 
 
 using GraphQL.Types;
using NHLStats.Core.Models;

namespace NHLStats.Api.Models
{
    public class SkaterStatisticType : ObjectGraphType<SkaterStatistic>
    {
        public SkaterStatisticType()
        {
            Field(x => x.Id);
            Field(x => x.SeasonId);
            Field(x => x.Season.Name).Name("season");
            Field(x => x.League.Abbreviation).Name("league");
            Field(x => x.Team.Name).Name("team");
            // graphql-dotnet can't currently automatically infer int16 so need to resolve manually
            Field<IntGraphType>("gp", resolve: context => context.Source.GamesPlayed);
            Field<IntGraphType>("goals", resolve: context => context.Source.Goals);
            Field<IntGraphType>("assists", resolve: context => context.Source.Assists);
            Field<IntGraphType>("points", resolve: context => context.Source.Points);
            Field<IntGraphType>("plusMinus", resolve: context => context.Source.PlusMinus);
        }
    }
}

 
