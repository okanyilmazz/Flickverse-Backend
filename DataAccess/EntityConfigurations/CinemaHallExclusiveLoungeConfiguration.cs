using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CinemaHallExclusiveLoungeConfiguration : IEntityTypeConfiguration<CinemaHallExclusiveLounge>
{
    public void Configure(EntityTypeBuilder<CinemaHallExclusiveLounge> builder)
    {
        builder.ToTable("CinemaHallExclusiveLounges").HasKey(chel => chel.Id);

        builder.Property(chel => chel.Id).HasColumnName("Id").IsRequired();
        builder.Property(chel => chel.CinemaHallId).HasColumnName("CinemaHallId").IsRequired();
        builder.Property(chel => chel.ExclusiveLoungeId).HasColumnName("ExclusiveLoungeId").IsRequired();

        builder.HasIndex(indexExpression: chel => chel.Id, name: "UK_Id").IsUnique();

        builder.HasOne(chel => chel.ExclusiveLounge)
           .WithMany(el => el.CinemaHallExclusiveLounges)
           .HasForeignKey(chel => chel.ExclusiveLoungeId);

        builder.HasOne(chel => chel.CinemaHall)
           .WithMany(ch => ch.CinemaHallExclusiveLounges)
           .HasForeignKey(chel => chel.CinemaHallId);

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
