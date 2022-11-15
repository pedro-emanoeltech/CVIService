using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Request;
using CVIServiceLibShared.App.Response;

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
