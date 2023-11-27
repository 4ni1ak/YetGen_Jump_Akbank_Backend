using FluentValidation.Persistence.Configurations;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FluentValidation.Persistence.Contexts
{
    public class PerfectAppDbContextFactory : IDesignTimeDbContextFactory<PerfectAppDbContext>
    {
        public PerfectAppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            var optionsBuilder = new DbContextOptionsBuilder<PerfectAppDbContext>();

            var connectionString = ConfigurationsDb.GetString("ConnectionStrings:PostgreSQL");

            optionsBuilder.UseNpgsql(connectionString);

            return new PerfectAppDbContext(optionsBuilder.Options);
        }
    }
    
}
