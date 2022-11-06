using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Context
{
    public class CVIContext : BaseContext
    {
        public CVIContext(DbContextOptions<CVIContext> options) : base(options)
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
        public DbSet<Curso>? Curso { get; set; }
    }
    

}
