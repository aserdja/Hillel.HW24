using HW24.DAL.Data;
using HW24.DAL.Models;
using HW24.DAL.Repositories.Interfaces;

namespace HW24.DAL.Repositories
{
	public class UserRepository(AppDbContext context) : IRepository<User>
	{
		private readonly AppDbContext _context = context;
		public async Task Add(User entity)
		{
			_context.Users.Add(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Delete(User entity)
		{
			_context.Users.Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Update(User entity)
		{
			_context.Users.Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}
