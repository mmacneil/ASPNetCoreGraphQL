
using GraphQL.Types;
using NHLStats.Core.Models;

namespace NHLStats.Api.Models
{
    public class PlayerType : ObjectGraphType<Player>
    {
        public PlayerType()
        {
            Field(x => x.Id).Description("The Id of the Droid.");
            Field(x => x.Name, nullable: true).Description("The name of the Droid.");
        }
    }



}
