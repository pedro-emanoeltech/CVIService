using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class CursoFormacaoAcademicaRepository : BaseRepository<CursoFormacaoAcademica> , ICursoFormacaoAcademicaRepository
    {
        public CursoFormacaoAcademicaRepository(CVIContext context) : base(context)
        {
        }
    }
}
