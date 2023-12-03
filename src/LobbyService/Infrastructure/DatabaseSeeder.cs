using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    internal static class DatabaseSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            List<Lobby> lobbies = [];

            for(int i = 0; i < 2000; i++) 
                lobbies.Add(new Lobby { Id = Guid.NewGuid(), Name = $"Lobby {Guid.NewGuid()}", CreatedDateTime = DateTime.UtcNow});
            modelBuilder.Entity<Lobby>().HasData(lobbies);
        }
    }
}
