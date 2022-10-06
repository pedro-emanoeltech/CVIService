using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace CurriculoVitaeInteligenteInfra.Context
{
   public abstract class BaseContext: DbContext, IUnitOfWork
    {
        public BaseContext(DbContextOptions<CVIContext> options) :
           base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", isEnabled: true);
        }
        public void Save()
        {
            base.SaveChanges();
        }
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
