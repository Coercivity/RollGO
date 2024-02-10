using Domain.Entities;

namespace LobbyAPI.Hubs.Models;

public record UserWithEntity
{
    public User User { get; set; } = null!;
    public EntertainmentEntity EntertainmentEntity { get; set; } = null!;
}
