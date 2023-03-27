using Infrastructure;

namespace Presentation; 

public class Program
{
    public static void Main(string[] args)
    {
        // CreateHostBuilder(args).Build().Run();
        
        var host = CreateHostBuilder(args).Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var dbContext = services.GetRequiredService<EFContext>();
            dbContext.Database.EnsureCreated();
        }

        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}