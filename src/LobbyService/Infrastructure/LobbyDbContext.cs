using Domain.Entities;
using Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class LobbyDbContext(DbContextOptions<LobbyDbContext> options) : DbContext(options)
    {
        public DbSet<Lobby> Lobbies { get; set; } = null!;
        public DbSet<UserWeight> UsersWeights { get; set; } = null!;
        public DbSet<EntertainmentEntity> EntertainmentEntities { get; set; } = null!;
        public DbSet<Meeting> Meetings { get; set; } = null!;
        public DbSet<LobbyUser> LobbyUsers { get; set; } = null!;
        public DbSet<LobbySettings> LobbySettings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            modelBuilder.ApplyConfiguration(new EntertainmentEntityMapping());
            modelBuilder.ApplyConfiguration(new MeetingMapping());
            modelBuilder.ApplyConfiguration(new UserWeightMapping());
            modelBuilder.ApplyConfiguration(new LobbyMapping());
            modelBuilder.ApplyConfiguration(new LobbyUserMapping());
            modelBuilder.ApplyConfiguration(new LobbySettingsMapping());
            DatabaseSeeder.Seed(modelBuilder);
        }
    }
}
