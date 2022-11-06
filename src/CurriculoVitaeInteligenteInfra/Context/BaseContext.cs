using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteInfra.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;



namespace CurriculoVitaeInteligenteInfra.Context
{
    public abstract class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<CVIContext> options) :
           base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", isEnabled: true);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntityComData && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntityComData)entityEntry.Entity).DateUpdate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntityComData)entityEntry.Entity).DateCreate = DateTime.Now;
                }
            }
            return await SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken: cancellationToken);
        }
            
        public override ChangeTracker ChangeTracker
        {
            get
            {
                base.ChangeTracker.LazyLoadingEnabled = false;
                base.ChangeTracker.CascadeDeleteTiming = CascadeTiming.OnSaveChanges;
                base.ChangeTracker.DeleteOrphansTiming = CascadeTiming.OnSaveChanges;
                return base.ChangeTracker;
            }
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
