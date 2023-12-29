using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    internal class EntertainmentEntityMapping()
        : BaseEntityMapping<EntertainmentEntity>(nameof(EntertainmentEntity))
    {
        public override void Configure(EntityTypeBuilder<EntertainmentEntity> builder)
        {
            builder
                .HasDiscriminator<bool>(x => x.IsSeries)
                .HasValue<Film>(false)
                .HasValue<Series>(true);

            builder.Property(x => x.NameEn).HasColumnName("NameEn").HasColumnType("varchar");

            builder.Property(x => x.NameRu).HasColumnName("NameRu").HasColumnType("varchar");

            builder.Property(x => x.PosterUrl).HasColumnName("PosterUrl").HasColumnType("varchar");

            builder.Property(x => x.WebUrl).HasColumnName("WebUrl").HasColumnType("varchar");

            builder
                .Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar");

            builder.Property(x => x.FilmLength).HasColumnName("FilmLength");
            builder.Property(x => x.Year).HasColumnName("Year").HasColumnType("int");

            builder.Property(x => x.ImdbId).HasColumnName("ImdbId").HasColumnType("varchar");

            builder.Property(x => x.KinopoiskId).HasColumnName("KinopoiskId").HasColumnType("int");

            builder
                .Property(x => x.ShortDescription)
                .HasColumnName("ShortDescription")
                .HasColumnType("varchar");

            builder.Property(x => x.RatingImdb).HasColumnName("RatingImdb");

            builder.Property(x => x.RatingKinopoisk).HasColumnName("RatingKinopoisk");
        }
    }
}
