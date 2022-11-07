using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco> , IEnderecoRepository
    {
        public EnderecoRepository(CVIContext context) : base(context)
        {
        }
        public override async Task<Endereco?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    throw new Exception("ID INVALIDO");
                }
                Endereco? TEntity = await _context.Set<Endereco>()
                .Include(p => p.Cidade!)
                .Include(p => p.Estado!)
                .ThenInclude(p => p.Pais!)
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
