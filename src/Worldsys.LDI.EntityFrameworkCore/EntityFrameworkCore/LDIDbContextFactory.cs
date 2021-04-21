using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Worldsys.LDI.Configuration;
using Worldsys.LDI.Web;

namespace Worldsys.LDI.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LDIDbContextFactory : IDesignTimeDbContextFactory<LDIDbContext>
    {
        public LDIDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LDIDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            LDIDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LDIConsts.ConnectionStringName));

            return new LDIDbContext(builder.Options);
        }
    }
}