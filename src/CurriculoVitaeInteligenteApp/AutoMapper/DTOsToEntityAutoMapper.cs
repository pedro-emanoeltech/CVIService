using AutoMapper;
using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteApp.AutoMapper
{
    public class DTOsToEntityAutoMapper :Profile
    {
        public DTOsToEntityAutoMapper()
        {
            //REQUEST 
            CreateMap<AuthenticateRequest, Conta>(MemberList.Destination).ReverseMap();
            CreateMap<ContaRequest, Conta>(MemberList.Destination).ReverseMap();
            CreateMap<CandidaturaRequest, Candidatura>(MemberList.Destination).ReverseMap();
            CreateMap<CargoRequest, Cargo>(MemberList.Destination).ReverseMap();
            CreateMap<CidadeRequest, Cidade>(MemberList.Destination).ReverseMap(); 
            CreateMap<ContatoRequest, Contato>(MemberList.Destination).ReverseMap();
            CreateMap<CursoFormacaoAcademicaRequest, CursoFormacaoAcademica>(MemberList.Destination).ReverseMap();
            CreateMap<CursoRequest, Curso>(MemberList.Destination).ReverseMap();
            CreateMap<EnderecoRequest, Endereco>(MemberList.Destination).ReverseMap();
            CreateMap<EscolaridadeRequest, Escolaridade>(MemberList.Destination).ReverseMap();
            CreateMap<EstadoRequest, Estado>(MemberList.Destination).ReverseMap();
            CreateMap<HistoricoProfissionalRequest, HistoricoProfissional>(MemberList.Destination).ReverseMap();
            CreateMap<IdiomaRequest, Idioma>(MemberList.Destination).ReverseMap();
            CreateMap<NacionalidadeRequest, Nacionalidade>(MemberList.Destination).ReverseMap();
            CreateMap<ObjetivoRequest, Objetivo>(MemberList.Destination).ReverseMap();
            CreateMap<PaisRequest, Pais>(MemberList.Destination).ReverseMap();
            CreateMap<PerfilRequest, Perfil>(MemberList.Destination).ReverseMap();
            CreateMap<SegmentoRequest, Segmento>(MemberList.Destination).ReverseMap();
            CreateMap<VagaRequest, Vaga>(MemberList.Destination).ReverseMap();

            //RESPONSES
            CreateMap<Conta,ContaResponse >(MemberList.Destination).ReverseMap();
            CreateMap<Conta, AuthenticateResponse>(MemberList.Destination)
                .ForMember(d => d.ContaId, opt => opt.MapFrom(src => src.Id!));
            CreateMap<CandidaturaResponse, Candidatura>(MemberList.Destination).ReverseMap();
            CreateMap<CargoResponse, Cargo>(MemberList.Destination).ReverseMap();
            CreateMap<CidadeResponse, Cidade>(MemberList.Destination).ReverseMap();
            CreateMap<ContatoResponse, Contato>(MemberList.Destination).ReverseMap();
            CreateMap<CursoFormacaoAcademicaResponse, CursoFormacaoAcademica>(MemberList.Destination).ReverseMap();
            CreateMap<CursoResponse, Curso>(MemberList.Destination).ReverseMap();
            CreateMap<EnderecoResponse, Endereco>(MemberList.Destination).ReverseMap();
            CreateMap<EscolaridadeResponse, Escolaridade>(MemberList.Destination).ReverseMap();
            CreateMap<EstadoResponse, Estado>(MemberList.Destination).ReverseMap();
            CreateMap<HistoricoProfissionalResponse, HistoricoProfissional>(MemberList.Destination).ReverseMap();
            CreateMap<IdiomaResponse, Idioma>(MemberList.Destination).ReverseMap();
            CreateMap<NacionalidadeResponse, Nacionalidade>(MemberList.Destination).ReverseMap();
            CreateMap<ObjetivoResponse, Objetivo>(MemberList.Destination).ReverseMap();
            CreateMap<PaisResponse, Pais>(MemberList.Destination).ReverseMap();
            CreateMap<PerfilResponse, Perfil>(MemberList.Destination).ReverseMap();
            CreateMap<SegmentoResponse, Segmento>(MemberList.Destination).ReverseMap();
            CreateMap<VagaResponse, Vaga>(MemberList.Destination).ReverseMap();

        }
    }
}
