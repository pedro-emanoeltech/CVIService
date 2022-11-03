using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class ContatoService : BaseService<Contato>, IContatoService
    {
        public ContatoService(IContatoRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
