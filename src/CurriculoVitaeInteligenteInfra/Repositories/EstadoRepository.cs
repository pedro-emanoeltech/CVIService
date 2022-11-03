using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class EstadoRepository : BaseRepository<Estado> , IEstadoRepository
    {
        public EstadoRepository(CVIContext context) : base(context)
        {
        }
    }
}
