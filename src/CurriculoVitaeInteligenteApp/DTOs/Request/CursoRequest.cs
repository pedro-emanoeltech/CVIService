using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class CursoRequest : BaseRequest
    {
        public string? NomeCurso { get; set; }

    }
}
