using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CandidaturaRepository : BaseRepository<Candidatura> , ICandidaturaRepository
    {
        public CandidaturaRepository(CVIContext context) : base(context)
        {
        }
    }
}
