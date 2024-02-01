using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class ExclusiveLoungeConfiguration : IEntityTypeConfiguration<ExclusiveLounge>
{
    public void Configure(EntityTypeBuilder<ExclusiveLounge> builder)
    {
        builder.ToTable("ExclusiveLounges").HasKey(el => el.Id);

        builder.Property(el => el.Id).HasColumnName("Id").IsRequired();
        builder.Property(el => el.Name).HasColumnName("Name").IsRequired();
        builder.Property(el => el.Description).HasColumnName("Description").IsRequired();

        builder.HasIndex(indexExpression: el => el.Id, name: "UK_Id").IsUnique();

        builder.HasMany(el => el.MovieExclusiveLounges);
        builder.HasMany(el => el.CinemaHallExclusiveLounges);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
