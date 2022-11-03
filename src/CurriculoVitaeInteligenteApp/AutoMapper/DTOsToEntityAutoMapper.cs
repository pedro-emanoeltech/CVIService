using AutoMapper;
using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.AutoMapper
{
    public class DTOsToEntityAutoMapper :Profile
    {
        public DTOsToEntityAutoMapper()
        {
            //REQUEST 
            CreateMap<AuthenticateDTORequest, Conta>().ReverseMap();
            CreateMap<ContaDTORequest, Conta>().ReverseMap();

            //RESPONSES
            CreateMap<Conta,ContaDToResponse > ().ReverseMap();
            CreateMap<Conta, AuthenticateDTOResponse>(MemberList.Destination)
                .ForMember(d => d.ContaId, opt => opt.MapFrom(src => src.Id!));


        }
    }
}
