using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class MeetingEntertainmentEntityLinkMapping() 
    : BaseEntityMapping<MeetingEntertainmentEntityLink>(nameof(MeetingEntertainmentEntityLink))
{
    public override void Configure(EntityTypeBuilder<MeetingEntertainmentEntityLink> builder)
    {
        base.Configure(builder);

        builder.HasOne(x => x.EntertainmentEntity)
            .WithMany()
            .IsRequired();

        builder.HasOne(x => x.Meeting)
            .WithMany()
            .IsRequired();

        builder.Ignore(x => x.User);
    }
}


