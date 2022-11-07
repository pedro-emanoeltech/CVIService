using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CursoFormacaoAcademicaRepository : BaseRepository<CursoFormacaoAcademica> , ICursoFormacaoAcademicaRepository
    {
        public CursoFormacaoAcademicaRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<CursoFormacaoAcademica?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                CursoFormacaoAcademica? TEntity = await _context.Set<CursoFormacaoAcademica>()
                .Include(p => p.Cidade!)
                .Include(p => p.Curso!)
                .FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
                if (TEntity == null)
                {
                    throw new Exception("erro ao consultar Id" + id);
                }
                return TEntity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
