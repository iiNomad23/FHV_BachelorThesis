using Domain;
using Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class EFContext : DbContext
{
    public DbSet<TestCase> TestCases { get; set; }
    public DbSet<TestPlan> TestPlans { get; set; }
    public DbSet<TestImplementation> TestImplementations { get; set; }
    public DbSet<TestRun> TestRuns { get; set; }
    public DbSet<TestEnvironment> TestEnvironments { get; set; }

    public EFContext(DbContextOptions<EFContext> options) : base(options)
    {
    }
    
    public EFContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new TestCaseConfiguration());
        modelBuilder.ApplyConfiguration(new TestPlanConfiguration());
        modelBuilder.ApplyConfiguration(new TestImplementationConfiguration());
        modelBuilder.ApplyConfiguration(new TestRunConfiguration());
        modelBuilder.ApplyConfiguration(new TestEnvironmentConfiguration());
    }
}