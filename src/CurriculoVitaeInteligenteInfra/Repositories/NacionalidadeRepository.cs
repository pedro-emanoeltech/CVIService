using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class NacionalidadeRepository : BaseRepository<Nacionalidade> , INacionalidadeRepository
    {
        public NacionalidadeRepository(CVIContext context) : base(context)
        {
        }
    }
}
