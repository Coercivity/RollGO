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
                string apiKey;
                if (configuration["Environment"] != "Development")
                {
                    apiKey = configuration["KINOPOISK_API_KEY"]!;
                }
                else
                {
                    apiKey = configuration["KinopoiskAPISettings:Apikey"]!;
                }
                client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
            });

            return services;
        }
    }
}
