using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;

namespace CurriculoVitaeInteligenteAPI.Configuration
{
    public static class Startup
    {

        public static IServiceCollection ConfigurationPostgres(this IServiceCollection services, IConfiguration configuration)
        { 
            services.AddDbContext<CVIContext>(options =>
            {
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
