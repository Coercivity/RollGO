using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class UserMapping() : BaseEntityMapping<User>(nameof(User))
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.HasMany(x => x.UserSessions)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);

        builder.Property(x => x.Username)
            .IsRequired()
            .HasColumnType("varchar");
    }
}
