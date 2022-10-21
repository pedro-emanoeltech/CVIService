using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Consumes("application/json", new string[] { })]
    [Produces("application/json", new string[] { })]
    public class ContaController : BaseControllers
    {
        public readonly IContaServiceApp _contaServiceApp;
        private readonly IMapper _mapper;   

        public ContaController(IContaServiceApp contaServiceApp,IMapper mapper)
        {
            _contaServiceApp = contaServiceApp;   
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Conta), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<Conta>>> GetList()
        {
            var result = await _contaServiceApp.GetList();
           
            if (result != null)
            {
                //IList<Conta> contaDTo = new IList<Conta>();
                //contaDTo = _mapper.Map<Conta>(result);
                return (ActionResult<IList<Conta>>)Ok(result);
            }
            else
            {
                return (ActionResult<IList<Conta>>)BadRequest("Falha na busca de Contas");
            }
        }


    }
}
