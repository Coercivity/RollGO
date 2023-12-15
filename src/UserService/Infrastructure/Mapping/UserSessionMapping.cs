using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class UserSessionMapping() : BaseEntityMapping<UserSession>(nameof(UserSession))
{
    public override void Configure(EntityTypeBuilder<UserSession> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.RefreshTokenId)
            .IsRequired()
            .HasColumnType("uuid");
    }
}
