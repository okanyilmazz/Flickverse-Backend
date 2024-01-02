using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.ToTable("Districts").HasKey(d => d.Id);

        builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
        builder.Property(d => d.CityId).HasColumnName("CityId").IsRequired();
        builder.Property(d => d.Name).HasColumnName("Name").IsRequired();

        builder.HasIndex(indexExpression: d => d.Id, name: "UK_Id").IsUnique();

        builder.HasOne(d => d.City);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}