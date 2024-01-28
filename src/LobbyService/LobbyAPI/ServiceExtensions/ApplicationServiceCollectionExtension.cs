using LobbyAPI.Hubs;
using LobbyAPI.Services;
using LobbyAPI.Services.Implementation;

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
            services.AddTransient<IMeetingService, MeetingService>();
            services.AddTransient<ILobbyService, LobbyService>();
            services.AddSingleton<InMemoryHubCache>();

            return services;
        }
    }
}
