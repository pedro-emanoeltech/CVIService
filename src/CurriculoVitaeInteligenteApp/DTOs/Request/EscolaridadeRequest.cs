using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class EscolaridadeRequest : BaseRequest
    {
        public Guid? PerfilId { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }

    }
}
