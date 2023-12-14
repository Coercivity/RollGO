using Domain.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DatabaseServiceCollectionExtension
{
    public static IServiceCollection AddDatabaseRepositories(this IServiceCollection services, string connectionString)
    {

        services.AddDbContext<UserDbContext>(options => options
            .UseNpgsql(connectionString));

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUserSessionRepository, UserSessionRepository>();

        return services;
    }
}
