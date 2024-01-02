using UserAPI.Services;

namespace UserAPI.Extensions;

public static class ApplicationServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServicesExtension(
        this IServiceCollection services
    )
    {

        services.AddTransient<ITokenService, TokenService>();
        services.AddTransient<IUserService, UserService>();

        return services;
    }
}