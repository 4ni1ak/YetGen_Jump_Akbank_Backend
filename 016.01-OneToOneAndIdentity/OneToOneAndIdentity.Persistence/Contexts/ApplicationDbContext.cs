using System.Reflection;
using Microsoft.EntityFrameworkCore;
using OneToOneAndIdentity.Domain.Entities;
using OneToOneAndIdentity.Domain.Identity;

namespace OneToOneAndIdentity.Persistence.Contexts
{
    public class ApplicationDbContext:DbContext 
    {
        public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Role>();
            modelBuilder.Ignore<UserSetting>();
            
            //IgnoreEntities(modelBuilder, typeof(User), typeof(Role));


            base.OnModelCreating(modelBuilder);
        }
        private void IgnoreEntities(ModelBuilder modelBuilder, params Type[] entityTypes)
        {
            foreach (var entityType in entityTypes)
            {
                modelBuilder.Ignore(entityType);
            }
        }
    }
}
