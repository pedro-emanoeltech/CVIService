using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class HistoricoProfissionalController : BaseController<HistoricoProfissional, HistoricoProfissionalRequest, HistoricoProfissionalResponse>
    {
        public HistoricoProfissionalController(IHistoricoProfissionalServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
