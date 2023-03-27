using Domain;
using Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class EFContext : DbContext
{
    public DbSet<TestCase> TestCases { get; set; }

    public EFContext(DbContextOptions<EFContext> options) : base(options)
    {
        // TestCases = Set<TestCase>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new TestCaseConfiguration());
    }
}