using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
{
    public void Configure(EntityTypeBuilder<MovieCategory> builder)
    {
        builder.ToTable("MovieCategories").HasKey(mc => mc.Id);

        builder.Property(mc => mc.Id).HasColumnName("Id").IsRequired();
        builder.Property(mc => mc.MovieId).HasColumnName("MovieId").IsRequired();
        builder.Property(mc => mc.CategoryId).HasColumnName("CategoryId").IsRequired();

        builder.HasIndex(indexExpression: mc => mc.Id, name: "UK_Id").IsUnique();

        builder.HasOne(mc => mc.Movie)
            .WithMany(m => m.MovieCategories)
            .HasForeignKey(mc => mc.MovieId);

        builder.HasOne(mc => mc.Category)
             .WithMany(c => c.MovieCategories)
             .HasForeignKey(mc => mc.CategoryId);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
