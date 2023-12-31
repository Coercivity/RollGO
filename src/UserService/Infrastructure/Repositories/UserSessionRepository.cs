using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserSessionRepository(UserDbContext context) : IUserSessionRepository
{
    private readonly UserDbContext context = context;
    private readonly DbSet<UserSession> sessionSet = context.Set<UserSession>();
    public async Task<UserSession> CreateAsync(UserSession session)
    {
        var addedSession = await sessionSet.AddAsync(session);
        await context.SaveChangesAsync();

        return addedSession.Entity;
    }

    public async Task<IEnumerable<UserSession>> DeleteAllUserSessionsAsync(Guid userId)
    {
        var sessions = sessionSet.Where(x => x.UserId == userId).ToList();
        sessionSet.RemoveRange(sessions);
        await context.SaveChangesAsync();

        return sessions;
    }

    public async Task<Guid?> DeleteAsync(Guid id)
    {
        var session = sessionSet.Find(id);
        if (session == null) {
            return null;
        }
        sessionSet.Remove(session);
        await context.SaveChangesAsync();
        return session.Id;
    }

    public Task<UserSession?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserSession>> GetUserSessionsByUserIdAsync(Guid userId)
    {
        return Task.FromResult(sessionSet.Where(x => x.UserId == userId).AsEnumerable());
    }

    public Task<UserSession?> UpdateAsync(UserSession entity)
    {
        throw new NotImplementedException();
    }
}
