using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class IdiomaController : BaseController<Idioma, IdiomaRequest, IdiomaResponse>
    {
        public IdiomaController(IIdiomaServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
