using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class CargoController : BaseController<Cargo, CargoRequest, CargoResponse>
    {
        public CargoController(ICargoServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
