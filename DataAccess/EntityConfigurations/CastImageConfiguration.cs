using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CastImageConfiguration : IEntityTypeConfiguration<CastImage>
{
    public void Configure(EntityTypeBuilder<CastImage> builder)
    {
        builder.ToTable("CastImages").HasKey(ci => ci.Id);

        builder.Property(ci => ci.Id).HasColumnName("Id").IsRequired();
        builder.Property(ci => ci.CastId).HasColumnName("CastId").IsRequired();
        builder.Property(ci => ci.ImagePath).HasColumnName("ImagePath").IsRequired();

        builder.HasIndex(indexExpression: ci => ci.Id, name: "UK_Id").IsUnique();

        builder.HasOne(ci => ci.Cast);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
