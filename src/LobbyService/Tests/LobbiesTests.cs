namespace Tests
{
    internal class LobbiesTests : BaseTests
    {

        [Test]
        public async Task CreateLobbyFromRepositoryTest()
        {
            Lobby newLobby = await _lobbyRepository.CreateAsync(new Lobby { Name = "test", AdminId = Guid.NewGuid() });
            Assert.That(newLobby, Is.Not.Null);
        }

        [Test]
        public async Task GetLobbiesFromRepositoryTest()
        {
            List<Lobby> lobbies = await _lobbyRepository.GetAll().ToListAsync();
            Assert.That(lobbies.Count, Is.GreaterThan(0));
        }

        [Test]
        public async Task UpdateLobbyFromRepositoryTest()
        {
            Lobby lobby = (await _lobbyRepository.GetAll().FirstOrDefaultAsync())!;

            lobby.Name = "test";
            Lobby updatedLobby = await _lobbyRepository.UpdateAsync(lobby);

            Assert.That(lobby.Name, Is.EqualTo(updatedLobby.Name));
        }

        [Test]
        public async Task DeleteLobbyFromRepositoryTest()
        {
            Lobby lobby = (await _lobbyRepository.GetAll().FirstOrDefaultAsync())!;
            Guid lobbyId = lobby.Id;

            await _lobbyRepository.DeleteAsync(lobbyId);
            Lobby? deleted = await _lobbyRepository.GetByIdAsync(lobbyId);

            Assert.That(deleted, Is.Null);
        }
    }
}