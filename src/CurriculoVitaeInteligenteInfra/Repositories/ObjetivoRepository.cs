using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class ObjetivoRepository : BaseRepository<Objetivo> , IObjetivoRepository
    {
        public ObjetivoRepository(CVIContext context) : base(context)
        {
        }
    }
}
