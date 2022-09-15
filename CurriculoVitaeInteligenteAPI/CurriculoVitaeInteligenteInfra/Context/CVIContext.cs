using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteInfra.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CurriculoVitaeInteligenteInfra.Context
{
    public class CVIContext : DbContext
    {
        public CVIContext(DbContextOptions<CVIContext> options) :
            base(options)
        {
        }

        public DbSet<Perfil>? Perfil { get; set; }
        public DbSet<Candidatura>? Candidaturas { get; set; }
        public DbSet<Cargo>? Cargos { get; set; }
        public DbSet<Conta>? Conta { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<CursoFormacaoAcademica>? CursoFormacaoAcademica { get; set; }
        public DbSet<Endereco>? Endereco { get; set; }
        public DbSet<Escolaridade>? Escolaridade { get; set; }
        public DbSet<Estado>? Estado { get; set; }
        public DbSet<HistoricoProfissional>? HistoricoProfissional { get; set; }
        public DbSet<Idioma>? Idioma { get; set; }
        public DbSet<Nacionalidade>? Nacionalidade { get; set; }
        public DbSet<Objetivo>? Objetivo { get; set; }
        public DbSet<Vaga>? Vaga { get; set; }
        public DbSet<Pais>? Pais { get; set; }
        public DbSet<Segmento>? Segmento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new CandidaturaMap());
            modelBuilder.ApplyConfiguration(new CargoMap());
            modelBuilder.ApplyConfiguration(new ContaMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new CursoFormacaoAcademicaMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EscolaridadeMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
            modelBuilder.ApplyConfiguration(new HistoricoProfissionalMap());
            modelBuilder.ApplyConfiguration(new IdiomaMap());
            modelBuilder.ApplyConfiguration(new NacionalidadeMap());
            modelBuilder.ApplyConfiguration(new ObjetivoMap());
            modelBuilder.ApplyConfiguration(new VagaMap());
            modelBuilder.ApplyConfiguration(new PaisMap());
            modelBuilder.ApplyConfiguration(new SegmentoMap());


        }

        
    }
    

}
