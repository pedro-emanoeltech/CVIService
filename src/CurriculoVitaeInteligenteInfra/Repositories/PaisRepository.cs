using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class PaisRepository : BaseRepository<Pais> , IPaisRepository
    {
        public PaisRepository(CVIContext context) : base(context)
        {
        }
    }
}
