using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteDomain.Entities
{
   public class Perfil : BaseEntityConta
    {
        public string? Nome { get; set; }
        public string? Apelido { get; set; }
        public Int64? CPF { get; set; }
        public Int64? CNPJ { get; set; }
        public int? Idade { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public Guid? SegmentoId { get; set; }
        public Guid? NacionalidadeId { get; set; }


        // Relacionamento
        public Segmento? Segmento { get; set; }

        public Nacionalidade? Nacionalidade { get; set; }

        public Endereco? Endereco { get; set; }

        public Contato? Contato { get; set; }

        public Objetivo? Objetivo { get; set; }

        public Idioma? Idioma { get; set; }

        public HistoricoProfissional? HistoricoProfissional { get; set; }

        public CursoFormacaoAcademica? CursoFormacaoAcademica { get; set; }




        //navegacao

        public virtual Conta? Conta { get; set; }

        public virtual IList<Candidatura>? Candidatura { get; set; }



    }
}
