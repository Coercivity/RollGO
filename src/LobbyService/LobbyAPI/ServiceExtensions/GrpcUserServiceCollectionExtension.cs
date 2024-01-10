using Grpc.Net.Client;
using static LobbyAPI.GrpcServices.User;

namespace LobbyAPI.ServiceExtensions
{
    public static class GrpcUserServiceCollectionExtension
    {
        public static IServiceCollection AddUserServiceExtension(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddSingleton(
                _ =>
                    new UserClient(
                        GrpcChannel.ForAddress(
                            configuration.GetConnectionString("GrpcUserService")!
                        )
                    )
            );

            return services;
        }
    }
}
