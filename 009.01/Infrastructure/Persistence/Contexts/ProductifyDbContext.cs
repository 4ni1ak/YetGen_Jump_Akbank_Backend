using Microsoft.EntityFrameworkCore;
using Productify.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Persistence.Contexts
{
    public class ProductifyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql($"Your information");


        }
    }
}