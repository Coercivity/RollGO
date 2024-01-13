using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

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

    public async Task<Guid?> DeleteAsync(Guid id)
    {
        var user = userSet.Find(id);
        if (user == null)
        {
            return null;
        }
        userSet.Remove(user);
        await context.SaveChangesAsync();
        return user.Id;
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

    public Task<IEnumerable<User>> GetUsersByIds(List<Guid> guids)
    {
        var users = userSet.Where(x => guids.Contains(x.Id));
        return Task.FromResult(users.AsEnumerable());
    }

    public async Task<User?> UpdateAsync(User entity)
    {
        var user = await userSet.FindAsync(entity.Id);
        if (user == null)
        {
            return null;
        }
        user.Icon = entity.Icon ?? user.Icon;
        user.Username = entity.Username ?? user.Username;
        user.Email = entity.Email ?? user.Email;
        user.Password = entity.Password ?? user.Password;
        userSet.Update(user);
        await context.SaveChangesAsync();
        return user;
    }
}
