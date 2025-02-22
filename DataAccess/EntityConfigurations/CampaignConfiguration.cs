using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
{
    public void Configure(EntityTypeBuilder<Campaign> builder)
    {
        builder.ToTable("Campaigns").HasKey(a => a.Id);
        builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
        builder.Property(a => a.Title).HasColumnName("Title").IsRequired();
        builder.Property(a => a.Description).HasColumnName("Description").IsRequired();
        builder.Property(a => a.StartDate).HasColumnName("StartDate").IsRequired();
        builder.Property(a => a.EndDate).HasColumnName("EndDate").IsRequired();

        builder.HasIndex(indexExpression: a => a.Id, name: "UK_Id").IsUnique();

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
