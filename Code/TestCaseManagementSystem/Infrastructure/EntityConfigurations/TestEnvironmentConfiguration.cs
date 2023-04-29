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
            .HasMaxLength(200);

        builder.Property(p => p.LongDescription);
        
        // TODO redo this with the testEnvId inside the Testsystem entity
        builder.OwnsMany(te => te.TestSystems, item =>
        {
            item.Property(p => p.Id);
            item.Property(p => p.DomainId);
            item.Property(p => p.Name);
            item.Property(p => p.Description);
        });
    }
}