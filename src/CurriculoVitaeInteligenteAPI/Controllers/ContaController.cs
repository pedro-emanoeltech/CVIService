using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class ContaController : BaseController<Conta, ContaRequest, ContaResponse>
    {
        private readonly IContaServiceApp _contaServiceApp;
        private readonly IMapper _mapper;
        public ContaController(IContaServiceApp contaServiceApp, IMapper mapper) : base(contaServiceApp, mapper)
        {
            _contaServiceApp = contaServiceApp;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthenticateResponse>> Authentcate([FromBody] AuthenticateRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Email ou Senha não pode ser Vazio");
                }

                var requestConta = _mapper.Map<Conta>(request);

                var authenticateDTOResponse = await _contaServiceApp.Authenticate(requestConta);
                if (authenticateDTOResponse is null)
                {
                    return BadRequest("falha ao autenticar");
                }

               
                return (ActionResult<AuthenticateResponse>)Ok(authenticateDTOResponse);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }

        }
    }
}
