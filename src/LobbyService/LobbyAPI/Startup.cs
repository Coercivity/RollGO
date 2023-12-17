using Microsoft.AspNetCore.Authentication.Cookies;
using LobbyAPI.Hubs;
using Infrastructure;
using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;
using LobbyAPI.Services;

namespace LobbyAPI
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseRepositories(Configuration.GetConnectionString("DefaultConnectionString")!);
            services.AddTransient<MeetingService>();
            services.AddTransient<UserService>();
            services.AddTransient<KinopoiskDataService>();
            services.AddSingleton<LobbyManager>();
            services.AddSignalR();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddHealthChecks();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
                AddCookie(op =>
                {
                    op.LoginPath = "/login";
                    op.AccessDeniedPath = "/denied";
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<LobbyDbContext>();
                dbContext.Database.Migrate();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lobby service API V1");
            });

            app.UseRouting();
            app.UseCookiePolicy();

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