using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CurriculoVitaeInteligenteDomain.Services;
using CurriculoVitaeInteligenteInfra.Repositories;

namespace CurriculoVitaeInteligenteAPI.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IContaRepository,ContaRepository> ();
            services.AddScoped<IContaService, ContaService>();



            return services;
        }
    }
}
