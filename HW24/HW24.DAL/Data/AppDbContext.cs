using HW24.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HW24.DAL.Data
{
	public class AppDbContext : DbContext
	{
		public virtual DbSet<User> Users => Set<User>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer();
		}
	}
}
