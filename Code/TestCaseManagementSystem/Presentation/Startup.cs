using Application;
using Application.Api;
using Domain.Repositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.OpenApi.Models;

namespace Presentation;

public class Startup
{
    private readonly IConfiguration _config;

    public Startup(IConfiguration config)
    {
        _config = config;
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // Register database with the DI container
        // services.AddDbContext<EFContext>(dbContextOptions =>
        // {
        //     dbContextOptions.UseSqlServer(_config.GetConnectionString("MariaDbConnectionString"));
        // });

        services.AddDbContext<EFContext>(
            dbContextOptions =>
            {
                var connectionString = _config.GetConnectionString("MariaDbConnectionString");
                
                dbContextOptions
                    .UseMySql(
                        connectionString,
                        ServerVersion.AutoDetect(connectionString)
                    )
                    .LogTo(
                        Console.WriteLine,
                        new[] { CoreEventId.QueryCompilationStarting, RelationalEventId.CommandExecuted }
                    )
                    .EnableSensitiveDataLogging();
            }
        );

        // Register repositories with the DI container
        services.AddTransient<ITestCaseRepository, TestCaseRepository>();
        services.AddTransient<ITestPlanRepository, TestPlanRepository>();
        services.AddTransient<ITestImplementationRepository, TestImplementationRepository>();
        services.AddTransient<ITestRunRepository, TestRunRepository>();
        services.AddTransient<ITestEnvironmentRepository, TestEnvironmentRepository>();

        // Register services with the DI container
        services.AddTransient<ITestCaseService, TestCaseService>();
        services.AddTransient<ITestPlanService, TestPlanService>();
        services.AddTransient<ITestImplementationService, TestImplementationService>();
        services.AddTransient<ITestRunService, TestRunService>();
        services.AddTransient<ITestEnvironmentService, TestEnvironmentService>();
        services.AddTransient<ITestEnvironmentManger, TestEnvironmentManager>();

        services.AddControllers();

        services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" }); });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}