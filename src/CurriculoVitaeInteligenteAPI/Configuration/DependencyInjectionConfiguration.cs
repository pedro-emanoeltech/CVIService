using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteApp.Services;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CurriculoVitaeInteligenteDomain.Services;
using CurriculoVitaeInteligenteInfra;
using CurriculoVitaeInteligenteInfra.Mapping;
using CurriculoVitaeInteligenteInfra.Repositories;

namespace CurriculoVitaeInteligenteAPI.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IContaRepository, ContaRepository>();
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<IContaServiceApp, ContaServiceApp>();

            services.AddScoped<ICandidaturaRepository, CandidaturaRepository>();
            services.AddScoped<ICandidaturaService, CandidaturaService>();
            services.AddScoped<ICandidaturaServiceApp, CandidaturaServiceApp>();

            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<ICargoService, CargoService>();
            services.AddScoped<ICargoServiceApp, CargoServiceApp>();

            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<ICidadeServiceApp, CidadeServiceApp>();

            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IContatoService, ContatoService>();
            services.AddScoped<IContatoServiceApp, ContatoServiceApp>();

            services.AddScoped<ICursoFormacaoAcademicaRepository, CursoFormacaoAcademicaRepository>();
            services.AddScoped<ICursoFormacaoAcademicaService, CursoFormacaoAcademicaService>();
            services.AddScoped<ICursoFormacaoAcademicaServiceApp, CursoFormacaoAcademicaServiceApp>();

            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<ICursoServiceApp, CursoServiceApp>();

            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IEnderecoServiceApp, EnderecoServiceApp>();

            services.AddScoped<IEscolaridadeRepository, EscolaridadeRepository>();
            services.AddScoped<IEscolaridadeService, EscolaridadeService>();
            services.AddScoped<IEscolaridadeServiceApp, EscolaridadeServiceApp>();

            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<IEstadoService, EstadoService>();
            services.AddScoped<IEstadoServiceApp, EstadoServiceApp>();

            services.AddScoped<IHistoricoProfissionalRepository, HistoricoProfissionalRepository>();
            services.AddScoped<IHistoricoProfissionalService, HistoricoProfissionalService>();
            services.AddScoped<IHistoricoProfissionalServiceApp, HistoricoProfissionalServiceApp>();

            services.AddScoped<IIdiomaRepository, IdiomaRepository>();
            services.AddScoped<IIdiomaService, IdiomaService>();
            services.AddScoped<IIdiomaServiceApp, IdiomaServiceApp>();

            services.AddScoped<INacionalidadeRepository, NacionalidadeRepository>();
            services.AddScoped<INacionalidadeService, NacionalidadeService>();
            services.AddScoped<INacionalidadeServiceApp, NacionalidadeServiceApp>();

            services.AddScoped<IObjetivoRepository, ObjetivoRepository>();
            services.AddScoped<IObjetivoService, ObjetivoService>();
            services.AddScoped<IObjetivoServiceApp, ObjetivoServiceApp>();

            services.AddScoped<IPaisRepository, PaisRepository>();
            services.AddScoped<IPaisService, PaisService>();
            services.AddScoped<IPaisServiceApp, PaisServiceApp>();

            services.AddScoped<IPerfilRepository, PerfilRepository>();
            services.AddScoped<IPerfilService, PerfilService>();
            services.AddScoped<IPerfilServiceApp, PerfilServiceApp>();

            services.AddScoped<ISegmentoRepository, SegmentoRepository>();
            services.AddScoped<ISegmentoService, SegmentoService>();
            services.AddScoped<ISegmentoServiceApp, SegmentoServiceApp>();

            services.AddScoped<IVagaRepository, VagaRepository>();
            services.AddScoped<IVagaService, VagaService>();
            services.AddScoped<IVagaServiceApp, VagaServiceApp>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
