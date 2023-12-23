using Domain.Entities;
using Infrastructure;
using Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NameGenerator.Generators;


namespace Tests
{
    public class Tests
    {
        private LobbyDbContext _dbContext;
        private LobbyRepository _lobbyRepository;

        [SetUp]
        public void Setup()
        {
            // Set up the in-memory database and repository
            var serviceProvider = new ServiceCollection()
                .AddDbContext<LobbyDbContext>(options =>
                    options.UseInMemoryDatabase(databaseName: "InMemoryDatabase"))
                .BuildServiceProvider();

            _dbContext = serviceProvider.GetRequiredService<LobbyDbContext>();
            _lobbyRepository = new LobbyRepository(_dbContext);
            SeedData();
        }

        private void SeedData()
        {
            List<Lobby> lobbies = [];
            RealNameGenerator nameGenerator = new();
            GamerTagGenerator tagGenerator = new();

            for (int i = 0; i < 10; i++)
                lobbies.Add(new Lobby { Id = Guid.NewGuid(), Name = tagGenerator.Generate(), AdminId = Guid.NewGuid() });
            _dbContext.AddRange(lobbies);
            _dbContext.SaveChanges();
        }


        [Test]
        public async Task CreateLobbyFromRepositoryTest()
        {
            Lobby newLobby = await _lobbyRepository.CreateAsync(new Lobby { Name = "test", AdminId = Guid.NewGuid() });
            Assert.NotNull(newLobby);
        }

        [Test]
        public async Task GetLobbiesFromRepositoryTest()
        {
            List<Lobby> lobbies = await _lobbyRepository.GetAll().ToListAsync();
            Assert.Greater(lobbies.Count, 0);
        }

        [Test]
        public async Task UpdateLobbyFromRepositoryTest()
        {
            Lobby lobby = (await _lobbyRepository.GetAll().FirstOrDefaultAsync())!;

            lobby.Name = "test";
            Lobby updatedLobby = await _lobbyRepository.UpdateAsync(lobby);

            Assert.AreEqual(lobby.Name, updatedLobby.Name);
        }

        [Test]
        public async Task DeleteLobbyFromRepositoryTest()
        {
            Lobby lobby = (await _lobbyRepository.GetAll().FirstOrDefaultAsync())!;
            Guid lobbyId = lobby.Id;

            await _lobbyRepository.DeleteAsync(lobbyId);
            Lobby deleted = await _lobbyRepository.GetByIdAsync(lobbyId);

            Assert.IsNull(deleted);
        }
    }
}