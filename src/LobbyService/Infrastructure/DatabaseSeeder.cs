using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NameGenerator.Generators;

namespace Infrastructure
{
    internal static class DatabaseSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            List<Lobby> lobbies = [];
            GamerTagGenerator Generator = new();

            for (int i = 0; i < 3; i++)
                lobbies.Add(new Lobby 
                { Id = Guid.NewGuid(), 
                    Name = Generator.Generate(), 
                    AdminId = Guid.NewGuid(),
                    MinimalRating = 7.5f,
                    MoviesPerUser = 2,
                    WithCoefficient = true
                });
            modelBuilder.Entity<Lobby>().HasData(lobbies);


        }
    }
}
