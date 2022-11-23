using CurriculoVitaeInteligenteDomain.Entities;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteApp.Interfaces
{
    public interface ITokenServiceApp : IBaseServiceApp<TokenAuth>
    {
        Task<AuthenticateResponse?> GenerateToken(Conta user);
    }
}
