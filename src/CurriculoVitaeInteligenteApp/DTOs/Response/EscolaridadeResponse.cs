using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Content.Enums;

namespace CurriculoVitaeInteligenteApp.DTOs.Response
{
    public class EscolaridadeResponse : BaseResponse
    {
        public Guid? Perfil_Id { get; set; }
        public NivelAcademico? NivelAcademico { get; set; }


        public virtual PerfilResponse? Perfil { get; set; }
    }
}
