using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OneToOneAndIdentity.Domain.Entities;
using OneToOneAndIdentity.Domain.Identity;

namespace OneToOneAndIdentity.Persistence.Contexts
{
    public class YetgenIdentityContext:IdentityDbContext<User,Role,Guid>
    {

        public YetgenIdentityContext(DbContextOptions<YetgenIdentityContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Ignore<Category>();
            modelBuilder.Ignore<Product>();
            modelBuilder.Ignore<ProductCategory>();
            
            // IgnoreEntities(modelBuilder, typeof(Category), typeof(Product));


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
