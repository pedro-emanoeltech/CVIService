using CurriculoVitaeInteligenteApp.AutoMapper;
using CurriculoVitaeInteligenteDomain.Constant.settings;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
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

        public static IServiceCollection ConfiguratonsApi(this IServiceCollection services)
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

            services.AddAuthentication(o =>
            {
                o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(o =>
            {
                o.RequireHttpsMetadata = false;
                o.SaveToken = true;
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Token.Secret)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            //services.AddCors();
            //var key = Encoding.ASCII.GetBytes(Token.Secret);
            //services.AddAuthentication(p =>
            //{
            //    p.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    p.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            //}).AddJwtBearer(p =>
            //{
            //    p.RequireHttpsMetadata = false;
            //    p.SaveToken=true;
            //    p.TokenValidationParameters = new TokenValidationParameters()
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer  = false,
            //        ValidateAudience = false
            //    };
            //});
            services.AddAuthorization();
            services.AddEndpointsApiExplorer();

            return services;
        }

        public static WebApplication UseConfiguratonsApi(this WebApplication app)
        {
            app.UseHttpLogging();
            

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            return app;
        }


        public static IServiceCollection AutoMapperConfiguration(this IServiceCollection services)
        {

            services.AddAutoMapper(typeof (DTOsToEntityAutoMapper));
            services.AddAutoMapper(typeof(EntityToDTOsAutoMapper));
            return services;
        }


       
    }

}
