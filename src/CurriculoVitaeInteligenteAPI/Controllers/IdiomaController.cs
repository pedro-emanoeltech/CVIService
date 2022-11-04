using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class IdiomaController : BaseController<Idioma, IdiomaRequest, IdiomaResponse>
    {
        public IdiomaController(IIdiomaServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
