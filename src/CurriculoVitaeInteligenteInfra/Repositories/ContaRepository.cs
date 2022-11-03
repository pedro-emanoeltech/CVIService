using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using System.Diagnostics.Eventing.Reader;

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

        public async Task<Conta> Authenticate(Conta TEntity)
        {
            try
            {
                Conta login = new Conta();
                if (!string.IsNullOrEmpty(TEntity.Email) || !string.IsNullOrEmpty(TEntity.Senha))
                {
                var conta =  await base.GetFirstOrDefault(p => p.Email == TEntity.Email && p.Senha == TEntity.Senha);
                    if (conta is not null)
                    {
                        login = conta;
                    }
                }


                return login;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao fazer login" + e.Message);
            }
        }

    }


}
