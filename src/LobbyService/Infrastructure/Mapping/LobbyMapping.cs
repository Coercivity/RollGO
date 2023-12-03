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

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("varchar");
        }
    }
}
