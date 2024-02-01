using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CinemaHallConfiguration : IEntityTypeConfiguration<CinemaHall>
{
    public void Configure(EntityTypeBuilder<CinemaHall> builder)
    {
        builder.ToTable("CinemaHalls").HasKey(ch => ch.Id);

        builder.Property(ch => ch.Id).HasColumnName("Id").IsRequired();
        builder.Property(ch => ch.AddressId).HasColumnName("AddressId").IsRequired();
        builder.Property(ch => ch.Name).HasColumnName("Name").IsRequired();
        builder.Property(ch => ch.Description).HasColumnName("Description").IsRequired();

        builder.HasIndex(indexExpression: ch => ch.Id, name: "UK_Id").IsUnique();

        builder.HasOne(ch => ch.Address);
        builder.HasMany(ch => ch.CinemaHallExclusiveLounges);
        builder.HasMany(ch => ch.CinemaHallMovies);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}