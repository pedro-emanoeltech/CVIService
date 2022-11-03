using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Repositories
{
    public interface IContaRepository : IBaseRepository<Conta>
    {
        Task<Conta> Authenticate(Conta TEntity);
    }
}
