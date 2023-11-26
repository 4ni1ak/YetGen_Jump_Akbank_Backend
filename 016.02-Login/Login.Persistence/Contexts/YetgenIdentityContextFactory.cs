using Login.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Login.Persistence.Contexts
{
    public class YetgenIdentityContextFactory : IDesignTimeDbContextFactory<YetgenIdentityContext>
    {
        public YetgenIdentityContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<YetgenIdentityContext>();

            var connectionString = ConfigurationsDb.GetString("ConnectionStrings:PostgreSQL");

            optionsBuilder.UseNpgsql(connectionString);

            return new YetgenIdentityContext(optionsBuilder.Options);
        }
    }
}
