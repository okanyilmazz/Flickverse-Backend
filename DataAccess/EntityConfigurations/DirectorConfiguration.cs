using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class DirectorConfiguration : IEntityTypeConfiguration<Director>
{
    public void Configure(EntityTypeBuilder<Director> builder)
    {
        builder.ToTable("Directors").HasKey(d => d.Id);

        builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
        builder.Property(d => d.CountryId).HasColumnName("CountryId").IsRequired();
        builder.Property(d => d.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(d => d.LastName).HasColumnName("LastName").IsRequired();
        builder.Property(d => d.Biography).HasColumnName("Biography").IsRequired();
        builder.Property(d => d.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();

        builder.HasIndex(indexExpression: d => d.Id, name: "UK_Id").IsUnique();

        builder.HasOne(d => d.Country);
        builder.HasMany(d => d.MovieDirectors);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
