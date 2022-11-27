using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class PerfilController : BaseController<Perfil, PerfilRequest, PerfilResponse>
    {
        public PerfilController(IPerfilServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
            ConsiderarContaId = true;
        }

    }
}
