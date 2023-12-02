using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DatabaseServiceCollectionExtension 
    {
        public static IServiceCollection AddDatabaseRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LobbyDbContext>(options => options.UseNpgsql(connectionString));
            services.AddTransient<ILobbyRepository, LobbyRepository>();
            return services;
        }
    }
}
