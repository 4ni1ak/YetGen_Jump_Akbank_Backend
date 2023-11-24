using System.Reflection;
using ManyToMany.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManyToMany.Persistence.Contexts
{
    public class ApplicationDbContext:DbContext 
    {
        public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions): base(dbContextOptions) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
