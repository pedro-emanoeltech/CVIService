using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.AutoMapper
{
    public class EntityToDTOsAutoMapper: Profile
    {
        public EntityToDTOsAutoMapper()
        {
            CreateMap<Conta, ContaDTo>();
        }
    }
}
