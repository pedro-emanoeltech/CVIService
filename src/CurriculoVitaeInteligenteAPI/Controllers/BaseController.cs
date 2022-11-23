using AutoMapper;
using CurriculoVitaeInteligenteAPI.IControllers;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoVitaeInteligenteAPI.Controllers
{

    [Route("api/[controller]")]
    [Authorize]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Consumes("application/json", new string[] { })]
    [Produces("application/json", new string[] { })]
    [ApiController]
    public abstract class BaseController<T,TRequestDTO,TResponsesDTO >
        : ControllerBase , IBaseController<T, TRequestDTO,TResponsesDTO> where T : ClassBase where TRequestDTO : BaseRequest where TResponsesDTO : BaseResponse
    {
     
            private readonly IBaseServiceApp<T> _baseServiceApp;
            private readonly IMapper _mapper;

            public BaseController(IBaseServiceApp<T> baseServiceApp, IMapper mapper)
            {
                _baseServiceApp = baseServiceApp;
                _mapper = mapper;
            }

            [HttpGet]
            [Authorize]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<IQueryable<TResponsesDTO>>> GetList()
            {
                var result = await _baseServiceApp.GetList();
                if (result != null)
                {
                    var responseResult = _mapper.Map<IList<TResponsesDTO>>(result);
                    return (ActionResult<IQueryable<TResponsesDTO>>)Ok(responseResult);
                }
                else
                {
                    return (ActionResult<IQueryable<TResponsesDTO>>)BadRequest("Falha na busca de Contas");
                }
            }

            [HttpPost]
            public async Task<ActionResult<TResponsesDTO>> Add([FromBody] TRequestDTO request)
            {
                try
                {
                    if (request == null)
                    {
                        return (ActionResult<TResponsesDTO>)BadRequest("Conteúdo não pode ser nulo");
                    }

                    var requestConta = _mapper.Map<T>(request);

                    var result = await _baseServiceApp.Add(requestConta);
                    if (result is null)
                    {
                        return (ActionResult<TResponsesDTO>)BadRequest(result);
                    }

                    var responseResult = _mapper.Map<TResponsesDTO>(result);
                    return (ActionResult<TResponsesDTO>)Ok(responseResult);
                }
                catch (Exception e)
                {
                    return (ActionResult<TResponsesDTO>)BadRequest(e.Message);
                    throw;
                }
                
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(string id)
            {
                await _baseServiceApp.Remove(id);
                return Ok();
            }

            [HttpGet("{id}", Name = "Get[Controller]")]
            [ProducesResponseType(404)]
            public async Task<ActionResult<T>> Get(string id)
            {
                var result = await _baseServiceApp.Get(id);
                if (result == null)
                {
                    return (ActionResult<T>)BadRequest();
                }

                return (ActionResult<T>)Ok(result);
            }

            //[HttpGet]
            //[ProducesResponseType(typeof(ContaDToResponse), 400)]
            //[ProducesResponseType(typeof(ContaDToResponse), 500)]
            //public virtual async Task<ActionResult<IQueryable<ContaDToResponse>>> GetToList()
            //{
            //    var result = await _contaServiceApp.GetToList();
            //    if (result != null)
            //    {
            //        return (ActionResult<IQueryable<ContaDToResponse>>)BadRequest("Sem resultado obtido");
            //    }

            //    return (ActionResult <IQueryable<ContaDToResponse>>)Ok(result);
            //}

            [HttpPut("{id}")]
            [Consumes("application/json", new string[] { })]
            public async Task<ActionResult<T>> Edit([FromBody] TRequestDTO request, string id)
            {
                if (request == null)
                {
                    return (ActionResult<T>)BadRequest("Conteúdo não pode ser nulo");
                }

                //var validation = new ContaDTOValidation().Validate(request);
                //if (!validation.IsValid)
                //{
                //    return (ActionResult<TResponsesDTO>)BadRequest("Conteúdo não pode ser nulo" + validation);
                //}
                var resultGet = await _baseServiceApp.Get(id);
                if (resultGet == null)
                {
                    return (ActionResult<T>)BadRequest("ID nao encontrado");
                }
                var requestConta = _mapper.Map(request, resultGet);

                var result = await _baseServiceApp.Edit(id, requestConta);
                if (result is null)
                {
                    return (ActionResult<T>)BadRequest("Falha ao atualizar dados");
                }

                return (ActionResult<T>)Ok(result);
            }



    }
    
}
