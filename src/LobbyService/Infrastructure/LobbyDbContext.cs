using Domain.Entities;
using Infrastructure.Mapping.Postgre;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class LobbyDbContext(DbContextOptions<LobbyDbContext> options) : DbContext(options)
    {
        public DbSet<EntertainmentEntity> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntertainmentEntityMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
