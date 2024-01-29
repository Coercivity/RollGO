using Domain.Entities;
using Infrastructure.Repository;
using LobbyAPI.Hubs.Models;

namespace LobbyAPI.Services.Implementation;

public class LobbyService(ILobbyRepository lobbyRepository, IMeetingService meetingService) : ILobbyService
{
    private readonly ILobbyRepository _lobbyRepository = lobbyRepository;
    private readonly IMeetingService _meetingService = meetingService;

    public async Task<Lobby> CreateLobby(Lobby lobby)
    {
       lobby = await _lobbyRepository.CreateAsync(lobby);

        var meeting = new Meeting
        {
            Lobby = lobby,
            IsActive = true,
        };

        var activeMeeting = new ActiveMeeting(meeting);
        _meetingService.ActiveMeetings.Add(activeMeeting);

        return lobby;
    }

    public async Task DeleteLobby(Guid id) => await _lobbyRepository.DeleteAsync(id);

    public IQueryable<Lobby> GetLobbies() => _lobbyRepository.GetAll();

    public async Task<Lobby?> GetLobby(Guid id) => await _lobbyRepository.GetByIdAsync(id);

    public IQueryable<Lobby> SearchLobbies(string lobbyName) => 
        _lobbyRepository.GetAll(x => x.Name.ToLower().Contains(lobbyName.ToLower()));

    public async Task<Lobby> UpdateLobby(Lobby lobby) => await _lobbyRepository.UpdateAsync(lobby);

}
