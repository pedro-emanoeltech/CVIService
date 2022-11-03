using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class CursoFormacaoAcademicaService : BaseService<CursoFormacaoAcademica>, ICursoFormacaoAcademicaService
    {
        public CursoFormacaoAcademicaService(ICursoFormacaoAcademicaRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
