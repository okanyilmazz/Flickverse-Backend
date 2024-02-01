using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CastConfiguration : IEntityTypeConfiguration<Cast>
{
    public void Configure(EntityTypeBuilder<Cast> builder)
    {
        builder.ToTable("Casts").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(c => c.LastName).HasColumnName("LastName").IsRequired();
        builder.Property(c => c.Biography).HasColumnName("Biography").IsRequired();
        builder.Property(c => c.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();

        builder.HasIndex(indexExpression: c => c.Id, name: "UK_Id").IsUnique();

        builder.HasOne(c => c.Country);
        builder.HasMany(c => c.MovieCasts);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}