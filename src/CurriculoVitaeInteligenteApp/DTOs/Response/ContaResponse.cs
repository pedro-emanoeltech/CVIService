using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class ContaResponse : BaseResponse
    {
        public string? Email { get; set; }


        public Status Status { get; set; } = Status.Ativo;
    }
}
