using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Services
{
    public interface ITokenService : IBaseService<TokenAuth>
    {
        Task<TokenAuth?> GenerateToken(Conta user);
    }
}
