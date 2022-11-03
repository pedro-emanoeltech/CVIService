using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CargoRepository : BaseRepository<Cargo> , ICargoRepository
    {
        public CargoRepository(CVIContext context) : base(context)
        {
        }
    }
}
