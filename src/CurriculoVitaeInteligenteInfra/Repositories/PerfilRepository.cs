using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class PerfilRepository : BaseRepository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<IList<Perfil>> GetList()
        {
            try
            {
                var lista = await _context.Set<Perfil>()!
                    .Include(p => p.Nacionalidade!)
                    .Include(p => p.Segmento!)
                    .Include(p => p.Endereco!)
                        .ThenInclude(p => p.Cidade!)
                    .Include(p => p.Endereco!)
                        .ThenInclude(p => p.Estado!)
                     .Include(p => p.Escolaridade!)
                     .Include(p => p.Contato!)
                     .Include(p => p.Objetivo!)
                     .Include(p => p.Idioma!)
                     .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Cargo!)
                      .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Segmento!)
                      .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Contato!)
                      .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Cidade)
                       .Include(p => p.CursoFormacaoAcademica!)
                        .ThenInclude(p => p.Cidade)
                       .Include(p => p.CursoFormacaoAcademica!)
                        .ThenInclude(p => p.Curso)
                    .ToListAsync<Perfil>();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Func<IQueryable<Perfil>, IIncludableQueryable<Perfil, object>>? GetIncludePedidoFull()
        {
            return p => p
                .Include(p => p.Nacionalidade!)
                    .Include(p => p.Segmento!)
                    .Include(p => p.Endereco!)
                        .ThenInclude(p => p.Cidade!)
                    .Include(p => p.Endereco!)
                        .ThenInclude(p => p.Estado!)
                     .Include(p => p.Escolaridade!)
                     .Include(p => p.Contato!)
                     .Include(p => p.Objetivo!)
                     .Include(p => p.Idioma!)
                     .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Cargo!)
                      .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Segmento!)
                      .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Contato!)
                      .Include(p => p.HistoricoProfissional!)
                        .ThenInclude(p => p.Cidade)
                       .Include(p => p.CursoFormacaoAcademica!)
                        .ThenInclude(p => p.Cidade)
                       .Include(p => p.CursoFormacaoAcademica!)
                        .ThenInclude(p => p.Curso)!;
        }
    }
}
