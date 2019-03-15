using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using NHLStats.Core.Data;


namespace NHLStats.Api.Helpers
{
    // https://github.com/graphql-dotnet/graphql-dotnet/issues/648#issuecomment-431489339
    public class ContextServiceLocator
    {
        public IPlayerRepository PlayerRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IPlayerRepository>();
        public ISkaterStatisticRepository SkaterStatisticRepository => _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<ISkaterStatisticRepository>();

        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
