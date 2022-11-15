using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class NacionalidadeController : BaseController<Nacionalidade, NacionalidadeRequest, NacionalidadeResponse>
    {
        public NacionalidadeController(INacionalidadeServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
