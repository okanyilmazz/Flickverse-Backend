using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MovieCastConfiguration : IEntityTypeConfiguration<MovieCast>
{
    public void Configure(EntityTypeBuilder<MovieCast> builder)
    {
        builder.ToTable("MovieCasts").HasKey(mc => mc.Id);

        builder.Property(mc => mc.Id).HasColumnName("Id").IsRequired();
        builder.Property(mc => mc.MovieId).HasColumnName("MovieId").IsRequired();
        builder.Property(mc => mc.CastId).HasColumnName("CastId").IsRequired();

        builder.HasIndex(indexExpression: mc => mc.Id, name: "UK_Id").IsUnique();

        builder.HasOne(mc => mc.Movie)
            .WithMany(m => m.MovieCasts)
            .HasForeignKey(mc => mc.MovieId);

        builder.HasOne(mc => mc.Cast)
             .WithMany(c => c.MovieCasts)
             .HasForeignKey(mc => mc.CastId);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}