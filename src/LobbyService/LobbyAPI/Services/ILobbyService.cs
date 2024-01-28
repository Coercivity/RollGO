using Domain.Entities;

namespace LobbyAPI.Services;

public interface ILobbyService
{
    public IQueryable<Lobby> GetLobbies();
    public Task<Lobby?> GetLobby(Guid id);
    public Task<Lobby> CreateLobby(Lobby lobby);
    public Task<Lobby> UpdateLobby(Lobby lobby);
    public Task DeleteLobby(Guid id);
    public IQueryable<Lobby> SearchLobbies(string lobbyName);
}
