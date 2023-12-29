using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

 internal static class DatabaseSeeder
{
     public static void Seed(ModelBuilder modelBuilder)
        {
            List<User> users = [];

            var passwordHash = BCrypt.Net.BCrypt.HashPassword("Password1!");
            users.Add(new User() {
                Username = "slavoyar",
                Password = passwordHash,
                Email = "slavoyar@hotmail.com"
            });
            users.Add(new User() {
                Username = "outflow",
                Password = passwordHash,
                Email = "outflow@rollgo.com"
            });
            users.Add(new User() {
                Username = "serpens",
                Password = passwordHash,
                Email = "serpens@hotmail.com"
            });

            modelBuilder.Entity<User>().HasData(users);
        }
}
