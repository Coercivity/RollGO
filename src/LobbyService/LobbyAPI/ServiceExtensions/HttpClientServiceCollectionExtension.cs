using LobbyAPI.HttpClients;

namespace LobbyAPI.ServiceExtensions
{
    public static class HttpClientServiceCollectionExtension
    {
        public static IServiceCollection AddKinopoiskAPIHttpClientExtension(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddHttpClient<KinopoiskHttpClient>(client =>
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
