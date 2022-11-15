using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;
namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class ObjetivoController : BaseController<Objetivo, ObjetivoRequest, ObjetivoResponse>
    {
        public ObjetivoController(IObjetivoServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
