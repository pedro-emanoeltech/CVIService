﻿using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CurriculoVitaeInteligenteDomain.Services;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class CursoFormacaoAcademicaServiceApp : BaseServiceApp<CursoFormacaoAcademica>, ICursoFormacaoAcademicaServiceApp
    {
        public CursoFormacaoAcademicaServiceApp(ICursoFormacaoAcademicaService service,IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
        }
       
    }
}