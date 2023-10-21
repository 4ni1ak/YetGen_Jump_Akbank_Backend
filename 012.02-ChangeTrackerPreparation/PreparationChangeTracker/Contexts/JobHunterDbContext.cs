using Microsoft.EntityFrameworkCore;
using PreparationChangeTracker.Entities;
using PreparationChangeTracker.Config;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreparationChangeTracker.Common;

namespace PreparationChangeTracker.Contexts
{
	internal class JobHunterDbContext: DbContext
	{

		public DbSet<JobPost> JobPosts { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL")); 
		}
		public override int SaveChanges()
		{
			var entries = ChangeTracker.Entries();
			foreach (var entry in entries)
			{
				if (entry.State == EntityState.Modified)
				{
					((IModifiedByEntity)entry.Entity).ModifiedOn = DateTime.UtcNow;
				}
				if (entry.State == EntityState.Added)
				{
					((ICreateByEntity)entry.Entity).CreatedOn = DateTime.UtcNow;
				}

			}

			return base.SaveChanges();
		}
	}
}
