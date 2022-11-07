using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class EstadoRepository : BaseRepository<Estado> , IEstadoRepository
    {
        public EstadoRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<Estado?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                Estado? TEntity = await _context.Set<Estado>()
                .Include(p => p.Pais!)
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
