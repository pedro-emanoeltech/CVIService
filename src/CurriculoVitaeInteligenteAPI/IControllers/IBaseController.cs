using CurriculoVitaeInteligenteApp.DTOs.Request;
using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteAPI.IControllers
{
    public interface IBaseController <
        T
        ,TRequestDTO
        ,TResponsesDTO
        > where T : ClassBase where TRequestDTO :BaseRequest where TResponsesDTO : BaseResponse
    {

    }
}
