using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MovieExclusiveLoungeConfiguration : IEntityTypeConfiguration<MovieExclusiveLounge>
{
    public void Configure(EntityTypeBuilder<MovieExclusiveLounge> builder)
    {
        builder.ToTable("MovieExclusiveLounges").HasKey(mel => mel.Id);

        builder.Property(mel => mel.Id).HasColumnName("Id").IsRequired();
        builder.Property(mel => mel.MovieId).HasColumnName("MovieId").IsRequired();
        builder.Property(mel => mel.ExclusiveLoungeId).HasColumnName("ExclusiveLoungeId").IsRequired();

        builder.HasIndex(indexExpression: mel => mel.Id, name: "UK_Id").IsUnique();

        builder.HasOne(mel => mel.Movie)
            .WithMany(m => m.MovieExclusiveLounges)
            .HasForeignKey(mel => mel.MovieId);

        builder.HasOne(mel => mel.ExclusiveLounge)
             .WithMany(el => el.MovieExclusiveLounges)
             .HasForeignKey(mel => mel.ExclusiveLoungeId);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
