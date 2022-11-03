using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class Escolaridade : BaseEntityComData
    {
        public Guid? Perfil_Id { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }


        public virtual Perfil? Perfil { get; set; }
    }
}
