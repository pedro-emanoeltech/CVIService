using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CVIServiceLibShared.Constants.Enums;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class ContaService : BaseService<Conta>, IContaService
    {
        private readonly IContaRepository _repositorio;
        public ContaService(IContaRepository repository, IUnitOfWork unitOfWork, IContaRepository repositorio) : base(repository, unitOfWork)
        {
            _repositorio = repositorio;
        }

        public async Task<Conta> Authenticate(Conta TEntity)
        {
            return await _repositorio.Authenticate(TEntity);
        }
    }


}
