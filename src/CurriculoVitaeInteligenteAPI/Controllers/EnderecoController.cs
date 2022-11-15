using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class EnderecoController : BaseController<Endereco, EnderecoRequest, EnderecoResponse>
    {
        public EnderecoController(IEnderecoServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
