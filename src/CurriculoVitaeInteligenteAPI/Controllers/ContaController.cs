using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs;
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
        private readonly IMapper _mapper;   
        public ContaController(IContaServiceApp contaServiceApp,IMapper mapper)
        {
            _contaServiceApp = contaServiceApp;   
            _mapper = mapper;
        }
   
        [HttpPost]
        public async Task<ActionResult<ContaDTo>> Add([FromBody] Conta request)
        {
            if (request == null)
            {
                return (ActionResult<ContaDTo>)BadRequest("Conteúdo não pode ser nulo");
            }
            var result = await _contaServiceApp.Add(request);
            return Ok();

        }

        [HttpGet]
        public virtual async Task<ActionResult<ContaDTo>> GetList()
        {
            var result = await _contaServiceApp.GetList();
           
            if (result != null)
            {
                ContaDTo contaDTo = new ContaDTo();
                contaDTo = _mapper.Map<ContaDTo>(result);
                return (ActionResult<ContaDTo>)Ok(contaDTo);
            }
            else
            {
                return (ActionResult<ContaDTo>)BadRequest("Falha na busca de Contas");
            }
 
        }

    }
}
