using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class CandidaturaService : BaseService<Candidatura>, ICandidaturaService
    {
        public CandidaturaService(ICandidaturaRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
