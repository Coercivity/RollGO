using Infrastructure;
using Microsoft.EntityFrameworkCore;
using UserAPI.Extensions;
using UserAPI.Mapping;
using UserAPI.Middlewares;

namespace UserAPI
{
    public class Startup(IConfiguration configuration)
    {
        private readonly string CorsPolicyName = "localhost";
        private IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddApplicationServicesExtension();

            services.AddDatabaseRepositories(Configuration.GetConnectionString("DefaultConnectionString")!);

            services.AddControllers();

            services.AddSwaggerExtension();

            services.AddAuthenticationExtension(Configuration);

            services.AddGrpc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<UserDbContext>();
                dbContext.Database.Migrate();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "User service API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(CorsPolicyName);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware<LoggerMiddleware>();
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GrpcServices.UserService>();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}