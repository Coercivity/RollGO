namespace LobbyAPI.ServiceExtensions
{
    public static class SignalRServiceCollectionExtension
    {
        public static IServiceCollection AddSignalRExtension(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetConnectionString("RedisConnectionString");
                options.InstanceName = "RedisInstance";
            });

            services
                .AddSignalR()
                .AddStackExchangeRedis(configuration.GetConnectionString("RedisConnectionString")!);

            return services;
        }
    }
}
