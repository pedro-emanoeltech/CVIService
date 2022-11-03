using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class EscolaridadeRepository : BaseRepository<Escolaridade> , IEscolaridadeRepository
    {
        public EscolaridadeRepository(CVIContext context) : base(context)
        {
        }
    }
}
