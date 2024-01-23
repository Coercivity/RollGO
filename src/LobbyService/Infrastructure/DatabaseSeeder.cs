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
                lobbies.Add(new Lobby { Id = Guid.NewGuid(), Name = Generator.Generate(), AdminId = Guid.NewGuid() });
            modelBuilder.Entity<Lobby>().HasData(lobbies);

            List<LobbySettings> lobbySettings = [];
            foreach (Lobby lobby in lobbies)
            {
                lobbySettings.Add(new LobbySettings()
                {
                    LobbyId = lobby.Id,
                    MinimalRating = 7.5f,
                    MoviesPerUser = 2,
                    WithKoefficient = true
                });
            }
            modelBuilder.Entity<LobbySettings>().HasData(lobbySettings);
        }
    }
}
