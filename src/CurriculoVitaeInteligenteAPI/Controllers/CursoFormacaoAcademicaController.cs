using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class CursoFormacaoAcademicaController : BaseController<CursoFormacaoAcademica, CursoFormacaoAcademicaRequest, CursoFormacaoAcademicaResponse>
    {
        public CursoFormacaoAcademicaController(ICursoFormacaoAcademicaServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
