using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class PerfilController : BaseController<Perfil, PerfilRequest, PerfilResponse>
    {
        public PerfilController(IPerfilServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
