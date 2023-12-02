using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    internal class BaseEntityMapping<TEntity>(string tableName) : IEntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        private string _tableName { get; set; } = tableName;

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(_tableName);

            builder.HasKey(k => k.Id);
            builder.Property(p => p.Id).HasColumnName("Id")
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired(true);

            builder.Property(p => p.CreatedDateTime).HasColumnName("CreatedDateTime").IsRequired();
        }
    }
}
