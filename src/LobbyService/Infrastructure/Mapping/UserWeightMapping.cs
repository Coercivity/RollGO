using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class UserWeightMapping() : BaseEntityMapping<UserWeight>(nameof(UserWeight))
{
    public override void Configure(EntityTypeBuilder<UserWeight> builder)
    {
        base.Configure(builder);

        builder
            .Property(x => x.UserId)
            .HasColumnName("UserId")
            .HasColumnType("uuid")
            .IsRequired();

        //Ef core relationships have a reference navigation property on both sides
        //builder.HasOne(m => m.Lobby)
        //    .WithMany()
        //    .IsRequired();
    }
}
