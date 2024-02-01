using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class DirectorImageConfiguration : IEntityTypeConfiguration<DirectorImage>
{
    public void Configure(EntityTypeBuilder<DirectorImage> builder)
    {
        builder.ToTable("DirectorImages").HasKey(di => di.Id);

        builder.Property(di => di.Id).HasColumnName("Id").IsRequired();
        builder.Property(di => di.DirectorId).HasColumnName("DirectorId").IsRequired();
        builder.Property(di => di.ImagePath).HasColumnName("ImagePath").IsRequired();

        builder.HasIndex(indexExpression: di => di.Id, name: "UK_Id").IsUnique();

        builder.HasOne(di => di.Director);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}