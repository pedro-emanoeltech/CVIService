using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CursoRepository : BaseRepository<Curso> , ICursoRepository
    {
        public CursoRepository(CVIContext context) : base(context)
        {
        }
    }
}
