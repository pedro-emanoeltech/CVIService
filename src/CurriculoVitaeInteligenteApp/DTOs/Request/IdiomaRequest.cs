using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteApp.DTOs.Request
{
    public class IdiomaRequest : BaseRequest
    {
        public Guid? Perfil_Id { get; set; }
        public string? Nome { get; set; }
        public NivelLinguagem? NivelLeitura { get; set; }
        public NivelLinguagem? NivelEscrita { get; set; }
        public NivelLinguagem? NivelConversacao { get; set; }


    }
}
