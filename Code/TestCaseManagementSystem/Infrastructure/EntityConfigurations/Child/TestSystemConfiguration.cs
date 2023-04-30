using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations.Child;

public class TestSystemConfiguration : IEntityTypeConfiguration<TestSystem>
{
    public void Configure(EntityTypeBuilder<TestSystem> builder)
    {
        builder.ToTable("TestSystems");

        builder.HasKey(e => e.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.Description);
    }
}