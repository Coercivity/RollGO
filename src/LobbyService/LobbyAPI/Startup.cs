using System.Text;
using Grpc.Net.Client;
using Infrastructure;
using LobbyAPI.Hubs;
using LobbyAPI.ServiceExtensions;
using LobbyAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using static LobbyAPI.GrpcServices.User;

namespace LobbyAPI
{
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseRepositories(Configuration);
            services.AddKinopoiskAPIHttpClinet(Configuration);

            services.AddSingleton(
                _ =>
                    new UserClient(
                        GrpcChannel.ForAddress(
                            Configuration.GetConnectionString("GrpcUserService")!
                        )
                    )
            );

            services.AddTransient<MeetingService>();
            services.AddTransient<UserService>();
            services.AddTransient<FilmsDataService>();
            services.AddSingleton<LobbyManager>();

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration.GetConnectionString("RedisConnectionString");
                options.InstanceName = "RedisInstance";
            });
            services
                .AddSignalR()
                .AddStackExchangeRedis(Configuration.GetConnectionString("RedisConnectionString")!);

            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.AddSecurityDefinition(
                    "Bearer",
                    new OpenApiSecurityScheme
                    {
                        Description =
                            "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "Bearer"
                    }
                );
                s.AddSecurityRequirement(
                    new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            Array.Empty<string>()
                        }
                    }
                );
            });
            services.AddHealthChecks();
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]!)
                        ),
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        ValidAudience = Configuration["Jwt:Issuer"]
                    };
                });
            services.AddCors(options =>
            {
                options.AddPolicy(
                    Configuration["CorsPolicy:Name"]!,
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

            app.UseCors(Configuration["CorsPolicy:Name"]!);

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
