using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Idioma :BaseEntity
    {
        public Guid? PessoaId { get; set; }
        public Idioma? Nome { get; set; }
        public NivelLinguagem? NivelLeitura { get; set; }
        public NivelLinguagem? NivelEscrita { get; set; }
        public NivelLinguagem? NivelConversacao { get; set; }


        public Pessoa? Pessoa { get; set; }

    }
}
