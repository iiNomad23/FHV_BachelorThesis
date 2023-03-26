using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class TestCaseConfiguration : IEntityTypeConfiguration<TestCase>
{
    public void Configure(EntityTypeBuilder<TestCase> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.DomainId)
            .IsRequired();

        builder.Property(u => u.ShortDescription)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(u => u.LongDescription);

        builder.Property(u => u.AuthorDescription)
            .IsRequired();
        builder.Property(u => u.CreateDate)
            .IsRequired();
        builder.Property(u => u.Priority)
            .IsRequired();
        
        builder.Property(u => u.ReferenceLink);
    }
}