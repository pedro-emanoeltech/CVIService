using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Idioma :BaseEntity
    {
        public Guid? PerfilId { get; set; }
        public string? Nome { get; set; }
        public NivelLinguagem? NivelLeitura { get; set; }
        public NivelLinguagem? NivelEscrita { get; set; }
        public NivelLinguagem? NivelConversacao { get; set; }


        public virtual Perfil? Perfil { get; set; }

    }
}
