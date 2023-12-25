using Domain.Entities;

namespace Domain.Repositories;

public interface IUserRepository : IRepositoryBase<User>
{
    public Task<User?> GetByUsernameAsync(string username);
    public Task<User?> GetByEmailAsync(string email);
}
