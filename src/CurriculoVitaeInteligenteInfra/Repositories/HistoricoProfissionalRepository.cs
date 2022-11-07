using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class HistoricoProfissionalRepository : BaseRepository<HistoricoProfissional> , IHistoricoProfissionalRepository
    {
        public HistoricoProfissionalRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<HistoricoProfissional?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                HistoricoProfissional? TEntity = await _context.Set<HistoricoProfissional>()
                .Include(p => p.Cidade!)
                .Include(p => p.Cargo!)
                .Include(p => p.Segmento!)
                .Include(p => p.Contato!)
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
