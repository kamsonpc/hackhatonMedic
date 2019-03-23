using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HealthBack.Configuration;
using HealthBack.Web;

namespace HealthBack.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HealthBackDbContextFactory : IDesignTimeDbContextFactory<HealthBackDbContext>
    {
        public HealthBackDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HealthBackDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HealthBackDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HealthBackConsts.ConnectionStringName));

            return new HealthBackDbContext(builder.Options);
        }
    }
}
