using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;


namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class IdiomaResponse : BaseResponse
    {
        public Guid? PerfilId { get; set; }
        public string? Nome { get; set; }
        public NivelLinguagem? NivelLeitura { get; set; }
        public NivelLinguagem? NivelEscrita { get; set; }
        public NivelLinguagem? NivelConversacao { get; set; }


        public virtual PerfilResponse? Perfil { get; set; }

    }
}
