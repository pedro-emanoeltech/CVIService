using CVIServiceLibShared.Constants.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class CursoFormacaoAcademica : BaseEntityComData
    {
        public Guid? PerfilId { get; set; }
        public Guid? CidadeId { get; set; }
        public Guid? CursoId { get; set; }

        public SituacaoCurso? SituacaoCurso { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public string? Instituicao { get; set; }
        public string? DescricaoCurso { get; set; }

        
        public Curso? Curso { get; set; }
        public Cidade? Cidade { get; set; }


    }
}
