using Microsoft.EntityFrameworkCore;
using Postman2.Domain.Common;
using Postman2.Domain.Entities;
using Postman2.Persistence.Config;

namespace Postman2.Persistence.Contexts
{
    public class Postman2DbContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<TaxiDriver> TaxiDrivers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Account)
                .WithOne(ba => ba.Owner)
                .HasForeignKey<BankAccount>(ba => ba.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}