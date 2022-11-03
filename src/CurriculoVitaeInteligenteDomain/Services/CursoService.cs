using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class CursoService : BaseService<Curso>, ICursoService
    {
        public CursoService(ICursoRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
