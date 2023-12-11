using Domain.Entities;

namespace Infrastructure.Repository.Implementation;

public class UserRepository : IUserRepository
{
    public Task<User> CreateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserName(Guid id, string userName)
    {
        throw new NotImplementedException();
    }
}
