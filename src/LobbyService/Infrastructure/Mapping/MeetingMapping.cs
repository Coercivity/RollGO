﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping;

internal class MeetingMapping() : BaseEntityMapping<Meeting>(nameof(Meeting))
{
    public override void Configure(EntityTypeBuilder<Meeting> builder)
    {
        base.Configure(builder);

        builder
            .Property(x => x.IsActive)
            .HasColumnName("IsActive")
            .HasColumnType("bool")
            .IsRequired();

        builder.Property(x => x.WinnerId).HasColumnName("WinnerId").HasColumnType("uuid");

        builder.HasOne(x => x.WinnerEntity).WithMany().IsRequired(false);
    }
}
