using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    internal class LobbyUserMapping() : BaseEntityMapping<LobbyUser>(nameof(LobbyUser))
    {
        public override void Configure(EntityTypeBuilder<LobbyUser> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.UserId)
                .HasColumnName("UserId")
                .HasColumnType("uuid")
                .IsRequired(true);
        }
    }
}
