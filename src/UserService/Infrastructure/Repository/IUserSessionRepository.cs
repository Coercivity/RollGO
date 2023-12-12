using Domain.Entities;

namespace Infrastructure.Repository;

public interface IUserSessionRepository : IRepositoryBase<UserSession>
{
    public Task<IEnumerable<UserSession>> DeleteAllUserSessions(Guid userId);
}
