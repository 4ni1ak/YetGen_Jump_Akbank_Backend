using FluentValidation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FluentValidation.Persistence.Contexts
{
    public class PerfectAppDbContext:DbContext
    {
        public DbSet<BankAccount> People { get; set; }
        public PerfectAppDbContext(DbContextOptions<PerfectAppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
