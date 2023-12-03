using Microsoft.AspNetCore.Authentication.Cookies;
using LobbyAPI.Hubs;
using Infrastructure;
using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;

namespace LobbyAPI
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILobbyRepository, LobbyRepository>();

            services.AddDatabaseRepositories(Configuration.GetConnectionString("DefaultConnectionString")!);
            services.AddSignalR();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
                AddCookie(op => {
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseRouting();
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<LobbyHub>("/lobby");
            });
        }
    }
}