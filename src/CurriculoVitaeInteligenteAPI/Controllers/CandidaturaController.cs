using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class CandidaturaController : BaseController<Candidatura, CandidaturaRequest, CandidaturaResponse>
    {
        public CandidaturaController(ICandidaturaServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
