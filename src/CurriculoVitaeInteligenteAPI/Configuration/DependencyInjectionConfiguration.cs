using CurriculoVitaeInteligenteApp.Services;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CurriculoVitaeInteligenteDomain.Services;
using CurriculoVitaeInteligenteInfra;
using CurriculoVitaeInteligenteInfra.Repositories;

namespace CurriculoVitaeInteligenteAPI.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IContaRepository,ContaRepository> ();
            //services.AddScoped<IContaService, ContaService>();

            services.AddHostedService<ContaApp>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
