using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class HistoricoProfissionalRepository : BaseRepository<HistoricoProfissional> , IHistoricoProfissionalRepository
    {
        public HistoricoProfissionalRepository(CVIContext context) : base(context)
        {
        }
    }
}
