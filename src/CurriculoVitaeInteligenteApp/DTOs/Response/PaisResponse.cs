using CurriculoVitaeInteligenteApp.DTOs.Response;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class PaisResponse : BaseResponse
    {
       
        public string? Nome { get; set; }

        public string? Sigla { get; set; }


        //navegacao
        public virtual EstadoResponse? Estado { get; set; }
    }
}
