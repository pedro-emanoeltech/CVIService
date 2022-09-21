using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;


namespace CurriculoVitaeInteligenteAPI.Configuration
{
    public static class StartupConfiguration
    {

        public static IServiceCollection ConfigurationPostgres(this IServiceCollection services, IConfiguration configuration)
        { 
            services.AddDbContext<CVIContext>(options =>
            {
                options.UseLoggerFactory(LoggerFactory.Create(build => build.AddConsole()));
                options.UseNpgsql(configuration.GetValue<string>("PostgresSettings:ConnectionString"));
            });
            return services;
        }
        public static WebApplication ConfigurationPostgresEscopo(this WebApplication application)
        {
            using IServiceScope serviceScope = application.Services.CreateScope();
            serviceScope.ServiceProvider.GetRequiredService<CVIContext>().Database.Migrate();
            return application;
        }
      





    }
}
