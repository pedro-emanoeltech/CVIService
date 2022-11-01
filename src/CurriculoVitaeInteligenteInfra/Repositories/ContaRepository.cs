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

        public override Task<Conta> Add(Conta TEntity, bool saveChanges = true)
        {
            if (TEntity.Email is not null)
            {
                TEntity.Email = TEntity!.Email!.ToLower();
            }
            
            return base.Add(TEntity, saveChanges);  
        }

        public override Task<Conta> Edit(string id, Conta TEntity)
        {
            if (TEntity.Email is not null)
            {
                TEntity.Email = TEntity!.Email!.ToLower();
            }

            return base.Edit(id, TEntity);
        }

    }


}
