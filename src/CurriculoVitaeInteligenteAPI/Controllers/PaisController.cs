using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class PaisController : BaseController<Pais, PaisRequest, PaisResponse>
    {
        public PaisController(IPaisServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
