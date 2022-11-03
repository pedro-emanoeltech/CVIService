using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class SegmentoService : BaseService<Segmento>, ISegmentoService
    {
        public SegmentoService(ISegmentoRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {

        }
    }   
}
