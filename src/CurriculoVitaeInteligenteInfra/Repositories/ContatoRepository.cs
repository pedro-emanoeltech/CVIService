using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class ContatoRepository : BaseRepository<Contato> , IContatoRepository
    {
        public ContatoRepository(CVIContext context) : base(context)
        {
        }
    }
}
