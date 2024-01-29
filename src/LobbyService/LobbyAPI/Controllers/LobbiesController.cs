using Domain.Entities;
using LobbyAPI.Controllers.Dtos;
using LobbyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LobbyAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LobbiesController(ILobbyService lobbyService) : ControllerBase
{
    private readonly ILobbyService _lobbyService = lobbyService;

    [HttpGet]
    public List<LobbyDto> GetAllLobbies()
    {
        var lobbies = _lobbyService.GetLobbies();
        List<LobbyDto> lobbyDtos = [.. lobbies.Select(x => new LobbyDto(x))];
        return lobbyDtos;
    }

    [HttpGet("{id}")]
    public async Task<LobbyDto> Get(Guid id)
    {
        var lobby = await _lobbyService.GetLobby(id);
        return new LobbyDto(lobby!);
    }

    [HttpPost]
    public async Task<LobbyDto> Create([FromBody] SaveLobbyDto saveLobbyDto)
    {
        Guid adminId = Guid.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)!.Value);

        var lobby = new Lobby()
        {
            Name = saveLobbyDto.Name,
            AdminId = adminId,
            MinimalRating = saveLobbyDto.MinimalRating,
            MoviesPerUser = saveLobbyDto.MoviesPerUser,
            WithCoefficient = saveLobbyDto.WithCoefficient
        };

        lobby = await _lobbyService.CreateLobby(lobby);

        return new(lobby);
    }

    [HttpPut("{id}")]
    public async Task<LobbyDto> Update([FromBody] SaveLobbyDto saveLobbyDto, Guid id)
    {
        var lobby = await _lobbyService.GetLobby(id);

        lobby.Name = saveLobbyDto.Name;
        lobby.MinimalRating = saveLobbyDto.MinimalRating;
        lobby.MoviesPerUser = saveLobbyDto.MoviesPerUser;
        lobby.WithCoefficient = saveLobbyDto.WithCoefficient;

        await _lobbyService.UpdateLobby(lobby);

        return new(lobby);
    }

    [HttpDelete("{id}")]
    public async Task<Guid> Delete(Guid id)
    {
        await _lobbyService.DeleteLobby(id);
        return id;
    }

    [HttpGet("search")]
    public List<LobbyDto> SearchLobby([FromQuery] string lobbyName)
    {
        IQueryable<Lobby> lobbies = _lobbyService.SearchLobbies(lobbyName);
        List<LobbyDto> lobbyDtos = lobbies.Select(x => new LobbyDto(x)).ToList();
        return lobbyDtos;
    }
}
