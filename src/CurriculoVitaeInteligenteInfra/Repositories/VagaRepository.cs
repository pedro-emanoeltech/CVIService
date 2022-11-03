using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class VagaRepository : BaseRepository<Vaga> , IVagaRepository
    {
        public VagaRepository(CVIContext context) : base(context)
        {
        }
    }
}
