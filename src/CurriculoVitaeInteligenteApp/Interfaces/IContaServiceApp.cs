using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.Interfaces
{
    public interface IContaServiceApp: IBaseServiceApp<Conta>
    {
        Task<AuthenticateResponse> Authenticate(Conta TEntity);
    }
}
