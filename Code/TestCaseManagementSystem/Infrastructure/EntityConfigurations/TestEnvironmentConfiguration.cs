using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class TestEnvironmentConfiguration : IEntityTypeConfiguration<TestEnvironment>
{
    public void Configure(EntityTypeBuilder<TestEnvironment> builder)
    {
        builder.ToTable("TestEnvironments");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.DomainId)
            .IsRequired();

        builder.Property(p => p.ShortDescription)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.LongDescription);

        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-many
        builder
            .HasMany(e => e.TestSystems)
            .WithOne()
            .HasPrincipalKey(p => p.DomainId)
            .IsRequired();

        builder
            .HasMany(e => e.TestPlans)
            .WithOne()
            .HasPrincipalKey(e => e.DomainId)
            .IsRequired();
    }
}