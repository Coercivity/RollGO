using Domain.Entities;

namespace Domain.Repositories;

public interface IUserSessionRepository : IRepositoryBase<UserSession>
{
    public Task<IEnumerable<UserSession>> DeleteAllUserSessions(Guid userId);
}
