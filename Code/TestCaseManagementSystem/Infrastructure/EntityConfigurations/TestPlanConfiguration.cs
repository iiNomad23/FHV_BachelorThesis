using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class TestPlanConfiguration : IEntityTypeConfiguration<TestPlan>
{
    public void Configure(EntityTypeBuilder<TestPlan> builder)
    {
        builder.ToTable("TestPlans");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.DomainId)
            .IsRequired();

        builder.Property(p => p.ShortDescription)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.LongDescription);
        
        builder.Property(p => p.CreateDate)
            .IsRequired();

        builder.Property(p => p.ReferenceLink);
    }
}