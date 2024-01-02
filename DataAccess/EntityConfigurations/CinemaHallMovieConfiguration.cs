using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CinemaHallMovieConfiguration : IEntityTypeConfiguration<CinemaHallMovie>
{
    public void Configure(EntityTypeBuilder<CinemaHallMovie> builder)
    {
        builder.ToTable("CinemaHallMovies").HasKey(chm => chm.Id);

        builder.Property(chm => chm.Id).HasColumnName("Id").IsRequired();
        builder.Property(chm => chm.CinemaHallId).HasColumnName("CinemaHallId").IsRequired();
        builder.Property(chm => chm.MovieId).HasColumnName("MovieId").IsRequired();

        builder.HasIndex(indexExpression: chm => chm.Id, name: "UK_Id").IsUnique();

        builder.HasOne(chm => chm.Movie)
           .WithMany(m => m.CinemaHallMovies)
           .HasForeignKey(chm => chm.MovieId);

        builder.HasOne(chm => chm.CinemaHall)
           .WithMany(ch => ch.CinemaHallMovies)
           .HasForeignKey(chm => chm.CinemaHallId);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}