using CurriculoVitaeInteligenteApp.DTOs.Response;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteApp.Interfaces
{
    public interface IContaServiceApp: IBaseServiceApp<Conta>
    {
        Task<AuthenticateDTOResponse> Authenticate(Conta TEntity);
    }
}
