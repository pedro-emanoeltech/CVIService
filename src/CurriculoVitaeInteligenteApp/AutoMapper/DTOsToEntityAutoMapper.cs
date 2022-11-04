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
            CreateMap<AuthenticateRequest, Conta>().ReverseMap();
            CreateMap<ContaRequest, Conta>().ReverseMap();

            //RESPONSES
            CreateMap<Conta,ContaResponse > ().ReverseMap();
            CreateMap<Conta, AuthenticateResponse>(MemberList.Destination)
                .ForMember(d => d.ContaId, opt => opt.MapFrom(src => src.Id!));


        }
    }
}
