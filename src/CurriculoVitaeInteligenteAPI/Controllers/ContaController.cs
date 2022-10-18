using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoVitaeInteligenteAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        public readonly IContaServiceApp _contaServiceApp;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;   
        }
   
        [HttpPost]
        public async Task<ActionResult<Conta>> Add([FromBody] Conta request)
        {
            if (request == null)
            {
                return (ActionResult<Conta>)BadRequest("Conteúdo não pode ser nulo");
            }
            var result = await _contaService.Add(request);
            return Ok();

        }

        [HttpGet]
        public virtual async Task<ActionResult<Conta>> GetList()
        {
            var result = await _contaService.GetList();
           
            if (result != null)
            {
                return (ActionResult<Conta>)Ok(result);
            }
            else
            {
                return (ActionResult<Conta>)BadRequest("Falha na busca de Contas");
            }
 
        }

    }
}
