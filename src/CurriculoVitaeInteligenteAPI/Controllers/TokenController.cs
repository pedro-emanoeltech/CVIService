using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteApp.Services;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class TokenController : BaseController<TokenAuth, AuthenticateRequest, AuthenticateResponse>
    {
        private readonly ITokenServiceApp _contaServiceApp;
        private readonly IMapper _mapper;
        public TokenController(ITokenServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
            _contaServiceApp = serviceApp;
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

                var authenticateDTOResponse = await _contaServiceApp.GenerateToken(requestConta);
                if (authenticateDTOResponse is null)
                {
                    return Unauthorized();
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
