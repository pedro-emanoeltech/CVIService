using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class TokenRepository : BaseRepository<TokenAuth>, ITokenRepository
    {
        public TokenRepository(CVIContext context) : base(context)
        {
        }
    }
}
