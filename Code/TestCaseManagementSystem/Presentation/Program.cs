using Infrastructure;

namespace Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        // Use this line of code when we are going production
        // CreateHostBuilder(args).Build().Run();

        // Remove the code block below when we are going production
        var host = CreateHostBuilder(args).Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var dbContext = services.GetRequiredService<EFContext>();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(
                webBuilder => { webBuilder.UseStartup<Startup>(); }
            );
    }
}