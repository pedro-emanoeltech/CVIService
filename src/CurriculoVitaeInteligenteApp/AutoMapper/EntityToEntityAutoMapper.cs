using AutoMapper;
using AutoMapper.Execution;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteApp.AutoMapper
{
    public class EntityToEntityAutoMapper : Profile
    {
        public EntityToEntityAutoMapper()
        {
            CreateMap<Conta,TokenAuth>(MemberList.Destination)
                .ForMember(d => d.ContaId, o => o.MapFrom(s => s.Id))
                .ForMember(dest => dest.Id, option => option.Ignore())
                .ReverseMap().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }

    }
}
