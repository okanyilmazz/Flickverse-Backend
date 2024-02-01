using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("Languages").HasKey(l => l.Id);

        builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
        builder.Property(l => l.Name).HasColumnName("Name").IsRequired();

        builder.HasIndex(indexExpression: l => l.Id, name: "UK_Id").IsUnique();

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}
