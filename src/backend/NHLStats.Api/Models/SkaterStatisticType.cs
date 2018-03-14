 
 
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
            Field(x => x.Season.Name).Name("season").Description("Season name");
            Field(x => x.League.Abbreviation).Name("league").Description("League");
            Field(x => x.Team.Name).Name("team").Description("Team");
            // graphql-dotnet can't currently automatically infer int16 so need to resolve manually
            Field<IntGraphType>("gp", resolve: context => context.Source.GamesPlayed,description: "Games played");
            Field<IntGraphType>("goals", resolve: context => context.Source.Goals, description: "Goals");
            Field<IntGraphType>("assists", resolve: context => context.Source.Assists, description: "Assists");
            Field<IntGraphType>("points", resolve: context => context.Source.Points, description: "Points");
            Field<IntGraphType>("plusMinus", resolve: context => context.Source.PlusMinus, description: "+/-");
        }
    }
}

 
