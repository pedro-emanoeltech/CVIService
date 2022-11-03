using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class NacionalidadeService : BaseService<Nacionalidade>, INacionalidadeService
    {
        public NacionalidadeService(INacionalidadeRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
