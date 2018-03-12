 
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using NHLStats.Api.Models;

namespace NHLStats.Api.Controllers
{
    [Route("api/[controller]")] 
    public class GraphQLController : Controller
    {
        private readonly PlayerQuery _playerQuery;

        public GraphQLController(PlayerQuery playerQuery)
        {
            _playerQuery = playerQuery;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = _playerQuery };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
