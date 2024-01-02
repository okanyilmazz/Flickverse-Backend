using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.ToTable("Movies").HasKey(m => m.Id);

        builder.Property(m => m.Id).HasColumnName("Id").IsRequired();
        builder.Property(m => m.CountryId).HasColumnName("CountryId").IsRequired();
        builder.Property(m => m.LanguageId).HasColumnName("LanguageId").IsRequired();
        builder.Property(m => m.Name).HasColumnName("Name").IsRequired();
        builder.Property(m => m.Description).HasColumnName("Description").IsRequired();
        builder.Property(m => m.IMDbRating).HasColumnName("IMDbRating").IsRequired();
        builder.Property(m => m.ReleaseDate).HasColumnName("ReleaseDate").IsRequired();
        builder.Property(m => m.Duration).HasColumnName("Duration").IsRequired();
        builder.Property(m => m.ProductionYear).HasColumnName("ProductionYear").IsRequired();

        builder.HasIndex(indexExpression: m => m.Id, name: "UK_Id").IsUnique();

        builder.HasOne(m => m.Country);
        builder.HasOne(m => m.Language);
        builder.HasMany(m => m.CinemaHallMovies);
        builder.HasMany(m => m.MovieCasts);
        builder.HasMany(m => m.MovieCategories);
        builder.HasMany(m => m.MovieDirectors);
        builder.HasMany(m => m.MovieExclusiveLounges);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}