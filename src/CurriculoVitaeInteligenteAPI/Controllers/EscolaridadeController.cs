using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class EscolaridadeController : BaseController<Escolaridade, EscolaridadeRequest, EscolaridadeResponse>
    {
        public EscolaridadeController(IEscolaridadeServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
