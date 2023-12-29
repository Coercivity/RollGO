using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DatabaseServiceCollectionExtension
    {
        public static IServiceCollection AddDatabaseRepositories(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddDbContext<LobbyDbContext>(
                options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnectionString")!)
            );

            services.AddTransient<ILobbyRepository, LobbyRepository>();
            services.AddTransient<IMeetingRepository, MeetingRepository>();
            return services;
        }
    }
}
