using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DatabaseServiceCollectionExtension
{
    public static IServiceCollection AddDatabaseRepositories(this IServiceCollection services, string connectionString)
    {

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUserSessionRepository, UserSessionRepository>();

        services.AddDbContext<UserDbContext>(options => options
            .UseNpgsql(connectionString));

        return services;
    }
}
