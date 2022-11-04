using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class NacionalidadeController : BaseController<Nacionalidade, NacionalidadeRequest, NacionalidadeResponse>
    {
        public NacionalidadeController(INacionalidadeServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
