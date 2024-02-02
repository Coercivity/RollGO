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
            if (configuration.GetConnectionString("GrpcUserService")!.Contains("user-api"))
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };
                services.AddSingleton(
                    _ =>
                        new UserClient(
                            GrpcChannel.ForAddress(
                                configuration.GetConnectionString("GrpcUserService")!,
                                new GrpcChannelOptions { HttpHandler = handler }
                            )
                        )
                );
            }
            else
            {
                services.AddSingleton(
                    _ =>
                        new UserClient(
                            GrpcChannel.ForAddress(
                                configuration.GetConnectionString("GrpcUserService")!
                            )
                        )
                );
            }

            return services;
        }
    }
}
