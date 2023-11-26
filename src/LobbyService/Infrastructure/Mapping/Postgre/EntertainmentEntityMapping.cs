using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping.Postgre
{
    public class EntertainmentEntityMapping : IEntityTypeConfiguration<EntertainmentEntity>
    {
        public void Configure(EntityTypeBuilder<EntertainmentEntity> builder)
        {
            builder.ToTable("FILMS");

            builder.HasDiscriminator<bool>("IS_SERIES")
                .HasValue<Film>(false)
                .HasValue<Series>(true);
                
        }
    }
}
