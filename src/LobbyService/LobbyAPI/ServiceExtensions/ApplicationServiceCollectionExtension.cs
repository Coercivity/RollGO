using LobbyAPI.Hubs;
using LobbyAPI.Services;

namespace LobbyAPI.ServiceExtensions
{
    public static class ApplicationServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServicesExtension(
            this IServiceCollection services
        )
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IFilmsDataService, FilmsDataService>();

            services.AddTransient<LobbyManager>();
            services.AddTransient<MeetingService>();
            services.AddSingleton<InMemoryHubCache>();

            return services;
        }
    }
}
