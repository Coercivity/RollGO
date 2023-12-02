using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    internal class LobbyMapping() : BaseEntityMapping<Lobby>(nameof(Lobby))
    {
        public override void Configure(EntityTypeBuilder<Lobby> builder)
        {
            base.Configure(builder);
            //builder.HasMany<UserWeight>(x => x.UserWeights);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar");

            builder.HasOne(x => x.Admin)
                .WithMany(nameof(User))
                .HasForeignKey("AdminId");

            builder.HasMany(x => x.UserWeights)
                .WithOne(nameof(UserWeight))
                .HasForeignKey("LobbyId");

            builder.HasMany(x => x.Meetings)
                .WithOne(nameof(Meeting))
                .HasForeignKey("MeetingId");
        }
    }
}
