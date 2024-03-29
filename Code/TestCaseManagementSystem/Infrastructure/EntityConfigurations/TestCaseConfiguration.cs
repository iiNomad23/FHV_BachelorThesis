﻿using Domain;
using Domain.Enums;
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
            .HasMaxLength(255);

        builder.Property(p => p.LongDescription);

        builder.Property(p => p.AuthorDescription)
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(p => p.CreateDate)
            .IsRequired();
        
        // Configure the enum property
        builder.Property(p => p.Priority)
            .HasConversion(
                e => e.ToString(),
                e => (Priority)Enum.Parse(typeof(Priority), e)
            )
            .HasMaxLength(15)
            .IsRequired();

        builder.Property(p => p.ReferenceLink);
    }
}