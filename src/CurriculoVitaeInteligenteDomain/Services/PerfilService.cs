using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class PerfilService : BaseService<Perfil>, IPerfilService
    {
        private readonly IPerfilRepository _repositorio;
        public PerfilService(IPerfilRepository repository, IUnitOfWork unitOfWork, IPerfilRepository repositorio) : base(repository, unitOfWork)
        {
            _repositorio = repositorio;
        }
        public override async Task<IList<Perfil>> GetList(string ContaId = "")
        {
          var lista =  await _repositorio.GetList(ContaId);
            return lista.Where(a => a.ContaId.ToString() == ContaId).ToList();
        }
    }   
}
