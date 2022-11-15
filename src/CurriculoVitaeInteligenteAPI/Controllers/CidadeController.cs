﻿using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteAPI.Controllers
{
    public class CidadeController : BaseController<Cidade, CidadeRequest, CidadeResponse>
    {
        public CidadeController(ICidadeServiceApp serviceApp, IMapper mapper) : base(serviceApp, mapper)
        {
        }

    }
}
