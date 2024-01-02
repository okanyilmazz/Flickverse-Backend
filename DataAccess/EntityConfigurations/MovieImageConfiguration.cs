using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MovieImageConfiguration : IEntityTypeConfiguration<MovieImage>
{
    public void Configure(EntityTypeBuilder<MovieImage> builder)
    {
        builder.ToTable("MovieImages").HasKey(mi => mi.Id);

        builder.Property(mi => mi.Id).HasColumnName("Id").IsRequired();
        builder.Property(mi => mi.MovieId).HasColumnName("MovieId").IsRequired();
        builder.Property(mi => mi.ImagePath).HasColumnName("ImagePath").IsRequired();

        builder.HasIndex(indexExpression: mi => mi.Id, name: "UK_Id").IsUnique();

        builder.HasOne(mi => mi.Movie);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}