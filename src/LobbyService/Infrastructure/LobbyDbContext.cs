using Domain.Entities;
using Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class LobbyDbContext(DbContextOptions<LobbyDbContext> options) : DbContext(options)
    {
        //public DbSet<EntertainmentEntity> Films { get; set; }
        public DbSet<Lobby> Lobbies { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            //modelBuilder.ApplyConfiguration(new EntertainmentEntityMapping());
            modelBuilder.ApplyConfiguration(new LobbyMapping());
            DatabaseSeeder.Seed(modelBuilder);

        }
    }
}
