using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PostgreSQL_EFC.Config;
using PostgreSQL_EFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL_EFC.Contexts
{
    internal class ShopifyDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var jsonReader = new JSONReader();
            //await jsonReader.ReadJSON();

            optionsBuilder.UseNpgsql($"Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;");

        }

    }
}
