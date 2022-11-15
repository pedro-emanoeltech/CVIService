using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class HistoricoProfissionalController : BaseController<HistoricoProfissional, HistoricoProfissionalRequest, HistoricoProfissionalResponse>
    {
        public HistoricoProfissionalController(IHistoricoProfissionalServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
