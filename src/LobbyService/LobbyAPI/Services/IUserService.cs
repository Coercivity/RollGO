using Domain.Entities;

namespace LobbyAPI.Services;

public interface IUserService
{
    public Task<IEnumerable<User>> GetUsersByIds(IList<Guid> userIds);
    public Task<User> GetUserById(Guid userId);
}
