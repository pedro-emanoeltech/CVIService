using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.AutoMapper
{
    public class DTOsToEntityAutoMapper :Profile
    {
        public DTOsToEntityAutoMapper()
        {
            CreateMap<ContaDTo,Conta>();
        }
    }
}
