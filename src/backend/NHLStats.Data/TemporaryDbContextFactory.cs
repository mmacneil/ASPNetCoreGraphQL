 
 
 
using Microsoft.EntityFrameworkCore;
 

namespace NHLStats.Data
{
    public class TemporaryDbContextFactory : DesignTimeDbContextFactoryBase<NHLStatsContext>
    {
        protected override NHLStatsContext CreateNewInstance(
            DbContextOptions<NHLStatsContext> options)
        {
            return new NHLStatsContext(options);
        }
    }
}
