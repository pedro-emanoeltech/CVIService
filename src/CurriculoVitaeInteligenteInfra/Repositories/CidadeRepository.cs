using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade> , ICidadeRepository
    {
        public CidadeRepository(CVIContext context) : base(context)
        {
        }
    }
}
