using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.DTOs.Validations;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.AspNetCore.Mvc;


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
        [ProducesResponseType(typeof(ContaDToResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<ContaDToResponse>>> GetList()
        {
            var result = await _contaServiceApp.GetList();
            if (result != null)
            {
                var responseResult = _mapper.Map<IList<ContaDToResponse>>(result);
                return (ActionResult<IList<ContaDToResponse>>)Ok(responseResult);
            }
            else
            {
                return (ActionResult<IList<ContaDToResponse>>)BadRequest("Falha na busca de Contas");
            }
        }

        [HttpPost]
        [ProducesResponseType(typeof(ContaDTORequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ContaDTORequest), 400)]
        [ProducesResponseType(typeof(ContaDTORequest), 500)]
        public async Task<ActionResult<ContaDToResponse>> Add([FromBody] ContaDTORequest request)
        {
            if (request == null)
            {
                return (ActionResult<ContaDToResponse>)BadRequest("Conteúdo não pode ser nulo");
            }

            var requestConta = _mapper.Map<Conta>(request);

            var result = await _contaServiceApp.Add(requestConta);
            if (result is null)
            {
                return (ActionResult<ContaDToResponse>)BadRequest(result);
            }

            var responseResult = _mapper.Map<ContaDToResponse>(result);
            return (ActionResult<ContaDToResponse>)Ok(responseResult);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ContaDToResponse), 400)]
        [ProducesResponseType(typeof(ContaDToResponse), 500)]
        public async Task<ActionResult> Delete(string id)
        {
            await _contaServiceApp.Remove(id);
            return Ok();
        }

        [HttpGet("{id}", Name = "Get[Controller]")]
        [ProducesResponseType(404)]
        [ProducesResponseType(typeof(Conta), 400)]
        [ProducesResponseType(typeof(Conta), 500)]
        public  async Task<ActionResult<Conta>> Get(string id)
        {
            var result = await _contaServiceApp.Get(id);
            if (result == null)
            {
                return (ActionResult<Conta>)BadRequest();
            }

            return (ActionResult<Conta>)Ok(result);
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(ResultFail), 400)]
        //[ProducesResponseType(typeof(ResultFail), 500)]
        //public virtual async Task<ActionResult<ResultList<TResponse>>> GetListPaginated([FromQuery] ODataParametrosRequest oDataParametros)
        //{
        //    ODataParametrosRequest oDataParametros2 = _mapper.Map<ODataParametrosRequest>(oDataParametros);
        //    IResult result = await _appService.GetListPaginated(oDataParametros2);
        //    ResultFail resultFail = result as ResultFail;
        //    if (resultFail != null)
        //    {
        //        return (ActionResult<ResultList<TResponse>>)BadRequest(resultFail.Message);
        //    }

        //    return (ActionResult<ResultList<TResponse>>)Ok(result);
        //}

        [HttpPut("{id}")]
        [Consumes("application/json", new string[] { })]
        [ProducesResponseType(typeof(ContaDToResponse), 400)]
        [ProducesResponseType(typeof(ContaDToResponse), 500)]
        public async Task<ActionResult<ContaDToResponse>> Edit([FromBody] ContaDTORequest request, string id)
        {
            if (request == null)
            {
                return (ActionResult<ContaDToResponse>)BadRequest("Conteúdo não pode ser nulo");
            }

            var validation = new ContaDTOValidation().Validate(request);
            if (!validation.IsValid)
            {
                return (ActionResult<ContaDToResponse>)BadRequest("Conteúdo não pode ser nulo"+validation);
            }
            var resultGet = await _contaServiceApp.Get(id);
            if (resultGet == null)
            {
                return (ActionResult<ContaDToResponse>)BadRequest("ID nao encontrado");
            }
            var requestConta = _mapper.Map(request,resultGet);

            var result = await _contaServiceApp.Edit(id, requestConta);
            if (result is null)
            {
                return (ActionResult<ContaDToResponse>)BadRequest("Falha ao atualizar dados" );
            }

            var responseResult = _mapper.Map<ContaDToResponse>(result);

            return (ActionResult<ContaDToResponse>)Ok(responseResult);
        }
    


    }
}
