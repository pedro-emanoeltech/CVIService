using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class CursoFormacaoAcademicaController : BaseController<CursoFormacaoAcademica, CursoFormacaoAcademicaRequest, CursoFormacaoAcademicaResponse>
    {
        public CursoFormacaoAcademicaController(ICursoFormacaoAcademicaServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
