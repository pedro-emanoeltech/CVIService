using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class PaisController : BaseController<Pais, PaisRequest, PaisResponse>
    {
        public PaisController(IPaisServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
