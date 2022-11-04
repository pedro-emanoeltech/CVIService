﻿using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.AutoMapper
{
    public class EntityToDTOsAutoMapper: Profile
    {
        public EntityToDTOsAutoMapper()
        {
            CreateMap<Conta, ContaResponse>();

            CreateMap<Conta, ContaResponse>();
        }
    }
}
