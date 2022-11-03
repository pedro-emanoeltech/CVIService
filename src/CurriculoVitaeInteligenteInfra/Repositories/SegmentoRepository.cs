using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class SegmentoRepository : BaseRepository<Segmento> , ISegmentoRepository
    {
        public SegmentoRepository(CVIContext context) : base(context)
        {
        }
    }
}
