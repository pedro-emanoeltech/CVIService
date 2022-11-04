using CurriculoVitaeInteligenteApp.DTOs.Request;

namespace CurriculoVitaeInteligenteDomain.Entities
{
    public class PaisRequest : BaseRequest
    {
       
        public string? Nome { get; set; }

        public string? Sigla { get; set; }

    }
}
