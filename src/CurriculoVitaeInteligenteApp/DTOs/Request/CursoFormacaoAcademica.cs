using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class CursoFormacaoAcademicaResponse : BaseRequest
    {

        public Guid? PerfilId { get; set; }
        public Guid? CursoId { get; set; }
        public Guid? CidadeId { get; set; }
        public SituacaoCurso? SituacaoCurso { get; set; }

        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? Instituicao { get; set; }

        public string? DescricaoCurso { get; set; }


        public CursoRequest? Curso { get; set; }
        public  CidadeRequest? Cidade { get; set; }


        // navegação
        public virtual PerfilRequest? Perfil { get; set; }
    }
}
