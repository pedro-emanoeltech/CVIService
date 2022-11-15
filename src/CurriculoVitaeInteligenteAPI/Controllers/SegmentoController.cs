using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class SegmentoController : BaseController<Segmento, SegmentoRequest, SegmentoResponse>
    {
        public SegmentoController(ISegmentoServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
