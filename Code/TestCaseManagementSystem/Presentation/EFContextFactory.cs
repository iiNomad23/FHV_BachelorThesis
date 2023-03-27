using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Presentation;

/**
 * This class is literally only here to be able to create Migrations
 */
public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
{
    public EFContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<EFContext>();

        var connectionString = configuration.GetConnectionString("MariaDbConnectionString");
        if (connectionString == null) 
        {
            throw new ArgumentNullException(null, "MariaDbConnectionString not found");
        }
        
        builder.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        );

        return new EFContext(builder.Options);
    }
}