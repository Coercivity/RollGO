using Infrastructure;
using LobbyAPI.Hubs;
using LobbyAPI.ServiceExtensions;
using Microsoft.EntityFrameworkCore;

namespace LobbyAPI
{
    public class Startup(IConfiguration configuration)
    {
        private IConfiguration _configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseRepositoriesExtension(_configuration);
            services.AddKinopoiskAPIHttpClinetExtension(_configuration);
            services.AddSignalRExtension(_configuration);
            services.AddUserServiceExtension(_configuration);

            services.AddApplicationServicesExtension();

            services.AddControllers();
            services.AddHealthChecks();

            services.AddSwaggerExtension(_configuration);
            services.AddAuthenticationExtension(_configuration);

            services.AddCors(options =>
            {
                options.AddPolicy(
                    _configuration["CorsPolicy:Name"]!,
                    policy =>
                    {
                        policy
                            .WithOrigins("http://localhost:5173")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    }
                );
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (
                var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope()
            )
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<LobbyDbContext>();
                dbContext.Database.Migrate();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lobby service API V1");
            });

            app.UseRouting();

            app.UseCors(_configuration["CorsPolicy:Name"]!);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("health");
                endpoints.MapControllers();
                endpoints.MapHub<LobbyHub>("/lobby");
            });
        }
    }
}
