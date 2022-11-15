using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteApp.Interfaces
{
    public interface IContaServiceApp: IBaseServiceApp<Conta>
    {
        Task<AuthenticateResponse> Authenticate(Conta TEntity);
    }
}
