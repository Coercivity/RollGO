using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    internal class EntertainmentEntityMapping : IEntityTypeConfiguration<EntertainmentEntity>
    {
        public void Configure(EntityTypeBuilder<EntertainmentEntity> builder)
        {
            builder.ToTable("FILMS");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NameEn).HasColumnName("NameEn").HasColumnType("varchar");
            builder.Property(x => x.NameRu).HasColumnName("NameRu").HasColumnType("varchar");
            builder.Property(x => x.PosterUrl).HasColumnName("PosterUrl").HasColumnType("varchar");
            builder.Property(x => x.WebUrl).HasColumnName("WebUrl").HasColumnType("varchar");
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("varchar");
            builder.Property(x => x.FilmLength).HasColumnName("FilmLength");
            builder.Property(x => x.Year).HasColumnName("Year").HasColumnType("int");
            builder.Property(x => x.ImdbId).HasColumnName("ImdbId");
            builder.Property(x => x.KinopoiskId).HasColumnName("KinopoiskId");
            builder.Property(x => x.ShortDescription).HasColumnName("ShortDescription");
            builder.Property(x => x.RatingImdb).HasColumnName("RatingImdb");


            builder.HasDiscriminator<bool>("IS_SERIES")
                .HasValue<Film>(false)
                .HasValue<Series>(true);

        }
    }
}


