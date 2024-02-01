using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MovieDirectorConfiguration : IEntityTypeConfiguration<MovieDirector>
{
    public void Configure(EntityTypeBuilder<MovieDirector> builder)
    {
        builder.ToTable("MovieDirectors").HasKey(md => md.Id);

        builder.Property(md => md.Id).HasColumnName("Id").IsRequired();
        builder.Property(md => md.MovieId).HasColumnName("MovieId");
        builder.Property(md => md.DirectorId).HasColumnName("DirectorId");

        builder.HasIndex(indexExpression: md => md.Id, name: "UK_Id").IsUnique();

        builder.HasOne(md => md.Movie)
            .WithMany(m => m.MovieDirectors)
            .HasForeignKey(md => md.MovieId);

        builder.HasOne(md => md.Director)
             .WithMany(d => d.MovieDirectors)
             .HasForeignKey(md => md.DirectorId);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
