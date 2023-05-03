using Domain;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace Infrastructure.EntityConfigurations;

public class TestRunConfiguration : IEntityTypeConfiguration<TestRun>
{
    public void Configure(EntityTypeBuilder<TestRun> builder)
    {
        builder.ToTable("TestRuns");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.DomainId)
            .IsRequired();

        builder.Property(p => p.StartDate)
            .IsRequired();

        builder.Property(p => p.EndDate)
            .IsRequired();

        builder.Property(p => p.State)
            .IsRequired();

        builder.Property(p => p.TestSystemId)
            .IsRequired()
            .HasMaxLength(255);

        builder
            .Property(p => p.ResultDetailsMap)
            .HasConversion<string>(
                d => JsonConvert.SerializeObject(d),
                s => JsonConvert.DeserializeObject<Dictionary<string, ResultDetails>>(s) ??
                     new Dictionary<string, ResultDetails>()
            );

        builder
            .OwnsMany(tr => tr.DeviceDetailsList, ddl =>
            {
                ddl.HasKey("Serial");
                
                ddl
                    .WithOwner()
                    .HasPrincipalKey(tr => tr.DomainId);

                ddl
                    .Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(255);
                
                ddl
                    .Property(p => p.Firmware)
                    .IsRequired()
                    .HasMaxLength(255);
                
                ddl
                    .Property(p => p.MkCode)
                    .IsRequired()
                    .HasMaxLength(255);
                
                ddl
                    .Property(p => p.Serial)
                    .IsRequired()
                    .HasMaxLength(255);
            });
    }
}