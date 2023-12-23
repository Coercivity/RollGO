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
            RealNameGenerator Generator = new();

            for (int i = 0; i < 10; i++) 
                lobbies.Add(new Lobby { Id = Guid.NewGuid(), Name = Generator.Generate(), CreatedDateTime = DateTime.UtcNow, AdminId = Guid.NewGuid()});
            modelBuilder.Entity<Lobby>().HasData(lobbies);
        }
    }
}
