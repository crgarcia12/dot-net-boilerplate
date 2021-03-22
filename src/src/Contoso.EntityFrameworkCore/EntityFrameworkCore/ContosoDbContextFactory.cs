using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Contoso.Configuration;
using Contoso.Web;

namespace Contoso.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ContosoDbContextFactory : IDesignTimeDbContextFactory<ContosoDbContext>
    {
        public ContosoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ContosoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ContosoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ContosoConsts.ConnectionStringName));

            return new ContosoDbContext(builder.Options);
        }
    }
}
