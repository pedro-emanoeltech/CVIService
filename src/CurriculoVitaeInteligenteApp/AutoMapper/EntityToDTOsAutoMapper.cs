using AutoMapper;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Response;

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
