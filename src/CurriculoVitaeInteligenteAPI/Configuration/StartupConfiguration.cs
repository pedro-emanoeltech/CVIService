using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

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
                options.EnableDetailedErrors().EnableSensitiveDataLogging();
            });
            return services;
        }
        public static WebApplication ConfigurationPostgresEscopo(this WebApplication application)
        {
            using IServiceScope serviceScope = application.Services.CreateScope();
            serviceScope.ServiceProvider.GetRequiredService<CVIContext>().Database.Migrate();
            return application;
        }

        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
              return services.AddSwaggerGen(opt =>
                {
                    opt.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = ("Curriculo Inteligente API "),
                        Version = "v1",
                        Description = "Projeto TCC Pedro Emanoel" ,
                        Contact= new OpenApiContact
                        {
                            Name="Pedro Emanoel",
                            Email = "pedro.emanoeltech@hotmail.com"
                        }
                   
                    });
                });
            
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(opt => 
            { opt.RoutePrefix = "swagger";
                opt.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1"); });
            
        }

        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {

            services.AddHttpLogging(delegate (HttpLoggingOptions options)
            {
                options.LoggingFields = HttpLoggingFields.ResponseStatusCode;
            });
            services.Configure(delegate (RouteOptions routeOptions)
            {
                routeOptions.LowercaseUrls = true;
                routeOptions.LowercaseQueryStrings = true;
            });
            
            services.AddHttpContextAccessor();
            services.AddControllers().ConfigureApiBehaviorOptions(delegate (ApiBehaviorOptions options)
            {
                options.SuppressMapClientErrors = true;
                options.SuppressModelStateInvalidFilter = true;
            }).AddJsonOptions(delegate (JsonOptions options)
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
            services.AddEndpointsApiExplorer();
            return services;
        }

        public static WebApplication UseApiConfiguration(this WebApplication app)
        {
            app.UseHttpLogging();
            

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
            return app;
        }

    }
}
