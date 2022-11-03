using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco> , IEnderecoRepository
    {
        public EnderecoRepository(CVIContext context) : base(context)
        {
        }
    }
}
