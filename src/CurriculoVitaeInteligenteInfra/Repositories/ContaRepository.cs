using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    public class ContaRepository : BaseRepository<Conta> ,IContaRepository
    {
        public ContaRepository(CVIContext context): base(context) 
        { 
            
        }


    }


}
