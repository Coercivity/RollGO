using Domain.Entities;

namespace Domain.Repositories;

public interface IUserSessionRepository : IRepositoryBase<UserSession>
{
    public Task<IEnumerable<UserSession>> DeleteAllUserSessionsAsync(Guid userId);

    public Task<IEnumerable<UserSession>> GetUserSessionsByUserIdAsync(Guid userId);
}
