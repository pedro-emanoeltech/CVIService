﻿using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class CidadeServiceApp : BaseServiceApp<Cidade>, ICidadeServiceApp
    {
        public CidadeServiceApp(ICidadeService service,IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
        }
       
    }
}