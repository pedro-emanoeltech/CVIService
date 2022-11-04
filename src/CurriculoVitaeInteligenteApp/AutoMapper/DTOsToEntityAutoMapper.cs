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
            CreateMap<CandidaturaRequest, Candidatura>().ReverseMap();
            CreateMap<CargoRequest, Cargo>().ReverseMap();
            CreateMap<CidadeRequest, Cidade>().ReverseMap(); 
            CreateMap<ContatoRequest, Contato>().ReverseMap();
            CreateMap<CursoFormacaoAcademicaRequest, CursoFormacaoAcademica>().ReverseMap();
            CreateMap<CursoRequest, Curso>().ReverseMap();
            CreateMap<EnderecoRequest, Endereco>().ReverseMap();
            CreateMap<EscolaridadeRequest, Escolaridade>().ReverseMap();
            CreateMap<EstadoRequest, Estado>().ReverseMap();
            CreateMap<HistoricoProfissionalRequest, HistoricoProfissional>().ReverseMap();
            CreateMap<IdiomaRequest, Idioma>().ReverseMap();
            CreateMap<NacionalidadeRequest, Nacionalidade>().ReverseMap();
            CreateMap<ObjetivoRequest, Objetivo>().ReverseMap();
            CreateMap<PaisRequest, Pais>().ReverseMap();
            CreateMap<PerfilRequest, Perfil>().ReverseMap();
            CreateMap<SegmentoRequest, Segmento>().ReverseMap();
            CreateMap<VagaRequest, Vaga>().ReverseMap();

            //RESPONSES
            CreateMap<Conta,ContaResponse > ().ReverseMap();
            CreateMap<Conta, AuthenticateResponse>(MemberList.Destination)
                .ForMember(d => d.ContaId, opt => opt.MapFrom(src => src.Id!));
            CreateMap<CandidaturaResponse, Candidatura>().ReverseMap();
            CreateMap<CargoResponse, Cargo>().ReverseMap();
            CreateMap<CidadeResponse, Cidade>().ReverseMap();
            CreateMap<ContatoResponse, Contato>().ReverseMap();
            CreateMap<CursoFormacaoAcademicaResponse, CursoFormacaoAcademica>().ReverseMap();
            CreateMap<CursoResponse, Curso>().ReverseMap();
            CreateMap<EnderecoResponse, Endereco>().ReverseMap();
            CreateMap<EscolaridadeResponse, Escolaridade>().ReverseMap();
            CreateMap<EstadoResponse, Estado>().ReverseMap();
            CreateMap<HistoricoProfissionalResponse, HistoricoProfissional>().ReverseMap();
            CreateMap<IdiomaResponse, Idioma>().ReverseMap();
            CreateMap<NacionalidadeResponse, Nacionalidade>().ReverseMap();
            CreateMap<ObjetivoResponse, Objetivo>().ReverseMap();
            CreateMap<PaisResponse, Pais>().ReverseMap();
            CreateMap<PerfilResponse, Perfil>().ReverseMap();
            CreateMap<SegmentoResponse, Segmento>().ReverseMap();
            CreateMap<VagaResponse, Vaga>().ReverseMap();

        }
    }
}
