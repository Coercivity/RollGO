using Domain.Entities;

namespace Infrastructure.Repository;

public interface IUserRepository : IRepositoryBase<User>
{
    public Task<User> UpdateUserName(Guid id, string userName);
}
