using Domain.Entities;

namespace Infrastructure.Repository.Implementation;

public class UserSessionRepository : IUserSessionRepository
{
    public Task<UserSession> CreateAsync(UserSession entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserSession>> DeleteAllUserSessions(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<UserSession> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserSession?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<UserSession> UpdateAsync(UserSession entity)
    {
        throw new NotImplementedException();
    }
}
