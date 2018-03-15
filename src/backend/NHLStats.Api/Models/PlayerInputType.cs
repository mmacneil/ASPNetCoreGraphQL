 

using GraphQL.Types;

namespace NHLStats.Api.Models
{
    public class PlayerInputType : InputObjectGraphType
    {
        public PlayerInputType()
        {
            Name = "PlayerInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("birthPlace");
            Field<StringGraphType>("height");
            Field<IntGraphType>("weightLbs");
            Field<DateGraphType>("birthDate");
        }
    }
}
