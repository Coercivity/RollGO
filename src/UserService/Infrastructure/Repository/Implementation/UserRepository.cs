using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Implementation;

public class UserRepository(UserDbContext context) : IUserRepository
{
    private readonly UserDbContext context = context;
    private readonly DbSet<User> userSet = context.Set<User>();

    public async Task<User> CreateAsync(User user)
    {
        var addedUser = await userSet.AddAsync(user);
        await context.SaveChangesAsync();

        return addedUser.Entity;
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByEmailAsync(string email)
    {
        return Task.FromResult(userSet.FirstOrDefault(x => x.Email == email));
    }

    public Task<User?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(userSet.Find(id));
    }

    public Task<User?> GetByUsernameAsync(string username)
    {
        return Task.FromResult(userSet.FirstOrDefault(x => x.Username == username));
    }

    public Task<User> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }
}
