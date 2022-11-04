using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class EnderecoController : BaseController<Endereco, EnderecoRequest, EnderecoResponse>
    {
        public EnderecoController(IEnderecoServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
