using Microsoft.EntityFrameworkCore;
using Postman.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Persistence.Contexts
{
	public class PostmanDbContext : DbContext
	{
		public DbSet<Car> Cars { get; set; }
		public DbSet<CarPost> CarPosts { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}
