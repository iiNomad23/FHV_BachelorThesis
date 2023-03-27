using Domain;
using Domain.enums;
using Domain.ids;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class TestCaseConfiguration : IEntityTypeConfiguration<TestCase>
{
    public void Configure(EntityTypeBuilder<TestCase> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.DomainId)
            .IsRequired();

        builder.Property(p => p.ShortDescription)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.LongDescription);

        builder.Property(p => p.AuthorDescription)
            .IsRequired();
        builder.Property(p => p.CreateDate)
            .IsRequired();
        
        // Configure the enum property
        builder.Property(p => p.Priority)
            .HasConversion(
                v => v.ToString(),
                v => (Priority)Enum.Parse(typeof(Priority), v)
            )
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(p => p.ReferenceLink);
    }
}