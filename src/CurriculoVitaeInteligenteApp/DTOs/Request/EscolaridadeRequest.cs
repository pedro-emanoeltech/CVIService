using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class EscolaridadeRequest : BaseRequest
    {
        public Guid? Perfil_Id { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }

    }
}
