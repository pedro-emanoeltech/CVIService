using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class IdiomaRepository : BaseRepository<Idioma> , IIdiomaRepository
    {
        public IdiomaRepository(CVIContext context) : base(context)
        {
        }
    }
}
