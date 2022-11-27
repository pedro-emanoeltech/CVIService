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
    public class ContaController : BaseController<Conta, ContaRequest, ContaResponse>
    {
        private readonly IContaServiceApp _baseServiceApp;
        private readonly IMapper _mapper;
        public ContaController(IContaServiceApp baseServiceApp, IMapper mapper) : base(baseServiceApp, mapper)
        {
            _baseServiceApp = baseServiceApp;
            _mapper = mapper;
        }

        [AllowAnonymous]
        public override async Task<ActionResult<ContaResponse>> Add([FromBody] ContaRequest request)
        {
            try
            {
                if (request == null)
                {
                    return (ActionResult<ContaResponse>)BadRequest("Conteúdo não pode ser nulo");
                }

                var requestConta = _mapper.Map<Conta>(request);

                var result = await _baseServiceApp.Add(requestConta);
                if (result is null)
                {
                    return (ActionResult<ContaResponse>)BadRequest(result);
                }

                var responseResult = _mapper.Map<ContaResponse>(result);
                return (ActionResult<ContaResponse>)Ok(responseResult);
            }
            catch (Exception e)
            {
                return (ActionResult<ContaResponse>)BadRequest(e.Message);
                throw;
            }

        }
    }
}
