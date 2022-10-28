using AutoMapper;
using CurriculoVitaeInteligenteAPI.IControllers;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.DTOs.Validations;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class ContaController : BaseController<Conta,ContaDTORequest,ContaDToResponse>
    {
        public ContaController(IContaServiceApp baseServiceApp, IMapper mapper) : base(baseServiceApp, mapper)
        {
        }



        //[HttpGet]
        //[ProducesResponseType(typeof(ContaDToResponse), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<IQueryable<ContaDToResponse>>> GetList()
        //{
        //    var result = await _contaServiceApp.GetList();
        //    if (result != null)
        //    {
        //        var responseResult = _mapper.Map<IList<ContaDToResponse>>(result);
        //        return (ActionResult<IQueryable<ContaDToResponse>>)Ok(responseResult);
        //    }
        //    else
        //    {
        //        return (ActionResult<IQueryable<ContaDToResponse>>)BadRequest("Falha na busca de Contas");
        //    }
        //}

        //[HttpPost]
        //[ProducesResponseType(typeof(ContaDTORequest), StatusCodes.Status200OK)]
        //[ProducesResponseType(typeof(ContaDTORequest), 400)]
        //[ProducesResponseType(typeof(ContaDTORequest), 500)]
        //public async Task<ActionResult<ContaDToResponse>> Add([FromBody] ContaDTORequest request)
        //{
        //    if (request == null)
        //    {
        //        return (ActionResult<ContaDToResponse>)BadRequest("Conteúdo não pode ser nulo");
        //    }

        //    var requestConta = _mapper.Map<Conta>(request);

        //    var result = await _contaServiceApp.Add(requestConta);
        //    if (result is null)
        //    {
        //        return (ActionResult<ContaDToResponse>)BadRequest(result);
        //    }

        //    var responseResult = _mapper.Map<ContaDToResponse>(result);
        //    return (ActionResult<ContaDToResponse>)Ok(responseResult);
        //}

        //[HttpDelete("{id}")]
        //[ProducesResponseType(typeof(ContaDToResponse), 400)]
        //[ProducesResponseType(typeof(ContaDToResponse), 500)]
        //public async Task<ActionResult> Delete(string id)
        //{
        //    await _contaServiceApp.Remove(id);
        //    return Ok();
        //}

        //[HttpGet("{id}", Name = "Get[Controller]")]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(typeof(Conta), 400)]
        //[ProducesResponseType(typeof(Conta), 500)]
        //public  async Task<ActionResult<Conta>> Get(string id)
        //{
        //    var result = await _contaServiceApp.Get(id);
        //    if (result == null)
        //    {
        //        return (ActionResult<Conta>)BadRequest();
        //    }

        //    return (ActionResult<Conta>)Ok(result);
        //}

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

        //[HttpPut("{id}")]
        //[Consumes("application/json", new string[] { })]
        //[ProducesResponseType(typeof(ContaDToResponse), 400)]
        //[ProducesResponseType(typeof(ContaDToResponse), 500)]
        //public async Task<ActionResult<ContaDToResponse>> Edit([FromBody] ContaDTORequest request, string id)
        //{
        //    if (request == null)
        //    {
        //        return (ActionResult<ContaDToResponse>)BadRequest("Conteúdo não pode ser nulo");
        //    }

        //    var validation = new ContaDTOValidation().Validate(request);
        //    if (!validation.IsValid)
        //    {
        //        return (ActionResult<ContaDToResponse>)BadRequest("Conteúdo não pode ser nulo"+validation);
        //    }
        //    var resultGet = await _contaServiceApp.Get(id);
        //    if (resultGet == null)
        //    {
        //        return (ActionResult<ContaDToResponse>)BadRequest("ID nao encontrado");
        //    }
        //    var requestConta = _mapper.Map(request,resultGet);

        //    var result = await _contaServiceApp.Edit(id, requestConta);
        //    if (result is null)
        //    {
        //        return (ActionResult<ContaDToResponse>)BadRequest("Falha ao atualizar dados" );
        //    }

        //    var responseResult = _mapper.Map<ContaDToResponse>(result);

        //    return (ActionResult<ContaDToResponse>)Ok(responseResult);
        //}



    }
}
