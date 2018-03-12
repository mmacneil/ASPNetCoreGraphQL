
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NHLStats.Api.Models;
using NHLStats.Core.Data;
using NHLStats.Data;
using NHLStats.Data.InMemory;

namespace NHLStats.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<PlayerQuery>();
            services.AddTransient<IPlayerRepository, PlayerRepository>();
            services.AddDbContext<NHLStatsContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:StarWarsDatabaseConnection"])
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, NHLStatsContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            db.EnsureSeedData();
        }
    }
}
