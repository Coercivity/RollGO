using LobbyAPI.Services;

namespace LobbyAPI.ServiceExtensions
{
    public static class HttpClientServiceCollectionExtension
    {
        public static IServiceCollection AddKinopoiskAPIHttpClinet(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddHttpClient<KinopoiskDataClient>(client =>
            {
                client.BaseAddress = new Uri(configuration["KinopoiskAPISettings:Url"]!);
                client.DefaultRequestHeaders.Add(
                    "X-API-KEY",
                    configuration["KinopoiskAPISettings:Apikey"]!
                );
            });

            return services;
        }
    }
}
