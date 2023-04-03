using Domain;
using Domain.enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class TestCaseConfiguration : IEntityTypeConfiguration<TestCase>
{
    public void Configure(EntityTypeBuilder<TestCase> builder)
    {
        builder.ToTable("TestCases");

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
                e => e.ToString(),
                e => (Priority)Enum.Parse(typeof(Priority), e)
            )
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(p => p.ReferenceLink);
    }
}