using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class ContatoController : BaseController<Contato, ContatoRequest, ContatoResponse>
    {
        public ContatoController(IContatoServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
