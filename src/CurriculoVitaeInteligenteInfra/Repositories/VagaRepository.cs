using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class VagaRepository : BaseRepository<Vaga> , IVagaRepository
    {
        public VagaRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<Vaga?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                Vaga? TEntity = await _context.Set<Vaga>()
                    .Include(p => p.Contato)
                    .Include(p => p.Cidade)
                    .Include(p => p.Estado)
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
