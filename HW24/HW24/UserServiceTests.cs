using HW24.DAL.Data;
using HW24.DAL.Models;
using HW24.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HW24
{
	public class UserServiceTests
	{
		[Fact]
		public async Task Add_expects_new_user_in_db()
		{
			var context = new AppDbContext();
			var user = new User { Name = "Ivan", Biography = "I'm a student" };
			var userRepo = new UserRepository(context);
			
			await userRepo.Add(user);

			var newUser = await context.Users.FirstOrDefaultAsync(u => u.Name == "Ivan" && u.Biography == "I'm a student");
			Assert.NotNull(newUser);
			Assert.Equal([user.Name, user.Biography], [newUser.Name, newUser.Biography]);
			context.Users.Remove(newUser);
		}

		[Fact]
		public async Task Delete_expects_remove_user_from_db()
		{
			var context = new AppDbContext();
			var testUser = new User { Name = "UserName", Biography = "UserBio" };
			var userRepo = new UserRepository(context);
			context.Users.Add(testUser);
			await context.SaveChangesAsync();

			await userRepo.Delete(testUser);

			var deletedUser = await context.Users.FirstOrDefaultAsync(u => u.Name == "UserName" && u.Biography == "I'm a student");
			Assert.Null(deletedUser);
		}

		[Fact]
		public async Task Update_expects_update_info_about_user()
		{
			var context = new AppDbContext();
			var testUser = new User { Name = "TestUserName123", Biography = "TestUserBio123" };
			var userRepo = new UserRepository(context);
			context.Users.Add(testUser);
			await context.SaveChangesAsync();
			var userToUpdate = await context.Users.FirstOrDefaultAsync(u => u.Name == "TestUserName123" && u.Biography == "TestUserBio123");
			userToUpdate.Name = "User123";
			userToUpdate.Biography = "UserBio123";

			await userRepo.Update(userToUpdate);

			var updatedUser = await context.Users.FirstOrDefaultAsync(u => u.Name == "User123" && u.Biography == "UserBio123");
			Assert.NotNull(updatedUser);
			context.Users.Remove(updatedUser);
		}
	}
}
