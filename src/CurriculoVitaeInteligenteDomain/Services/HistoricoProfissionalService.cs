using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class HistoricoProfissionalService : BaseService<HistoricoProfissional>, IHistoricoProfissionalService
    {
        public HistoricoProfissionalService(IHistoricoProfissionalRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
