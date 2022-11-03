using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class CargoService : BaseService<Cargo>, ICargoService
    {
        public CargoService(ICargoRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
