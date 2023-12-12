using Domain.Entities;

namespace Infrastructure.Repository;

public interface IUserRepository : IRepositoryBase<User>
{
    public Task<User> GetByUsernameAsync(string username);

    public Task<User> GetByEmailAsync(string email);
}
