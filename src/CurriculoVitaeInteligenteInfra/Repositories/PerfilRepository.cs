using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class PerfilRepository : BaseRepository<Perfil> , IPerfilRepository
    {
        public PerfilRepository(CVIContext context) : base(context)
        {
        }
    }
}
