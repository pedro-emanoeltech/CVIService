﻿using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class NacionalidadeServiceApp : BaseServiceApp<Nacionalidade>, INacionalidadeServiceApp
    {
        public NacionalidadeServiceApp(INacionalidadeService service,IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
        }
       
    }
}