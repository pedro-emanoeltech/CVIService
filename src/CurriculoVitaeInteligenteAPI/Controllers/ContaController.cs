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

    }
}
