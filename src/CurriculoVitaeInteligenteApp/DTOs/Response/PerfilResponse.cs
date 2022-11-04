using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class PerfilResponse : BaseResponse
    {
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public Int64? CPF { get; set; }
        public Int64? CNPJ { get; set; }
        public int? Idade { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public Guid? Segmento_Id { get; set; }
        public Guid? Nacionalidade_Id { get; set; }


        // Relacionamento
        public SegmentoResponse? Segmento { get; set; }

        public NacionalidadeResponse? Nacionalidade { get; set; }

        public EnderecoResponse? Endereco { get; set; }

        public ContatoResponse? Contato { get; set; }

        public ObjetivoResponse? Objetivo { get; set; }

        public IdiomaResponse? Idioma { get; set; }

        public HistoricoProfissionalResponse? HistoricoProfissional { get; set; }

        public CursoFormacaoAcademicaResponse? CursoFormacaoAcademica { get; set; }




        //navegacao

        public virtual Conta? Conta { get; set; }

        public virtual IList<CandidaturaResponse>? Candidatura { get; set; }



    }
}
