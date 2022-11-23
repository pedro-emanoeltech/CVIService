using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class ContaController : BaseController<Conta, ContaRequest, ContaResponse>
    {
        public ContaController(IContaServiceApp baseServiceApp, IMapper mapper) : base(baseServiceApp, mapper)
        {
        }
    }
}
