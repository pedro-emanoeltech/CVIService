using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class CidadeController : BaseController<Cidade, CidadeRequest, CidadeResponse>
    {
        public CidadeController(ICidadeServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
