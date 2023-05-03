using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations.Child;

public class TestEnvironmentPlanConfiguration : IEntityTypeConfiguration<TestEnvironmentPlan>
{
    public void Configure(EntityTypeBuilder<TestEnvironmentPlan> builder)
    {
        builder.ToTable("TestEnvironmentPlans");

        builder.HasKey(e => new {e.TestEnvironmentDomainId, e.TestPlanDomainId});

        builder
            .HasOne<TestEnvironment>()
            .WithMany(e => e.TestPlans)
            .HasPrincipalKey(e => e.DomainId)
            .IsRequired();

        builder
            .HasOne<TestPlan>()
            .WithMany(e => e.TestEnvironments)
            .HasPrincipalKey(e => e.DomainId)
            .IsRequired();
    }
}