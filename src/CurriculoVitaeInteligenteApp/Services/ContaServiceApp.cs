using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class ContaServiceApp : BaseServiceApp<Conta>, IContaServiceApp
    {
        public ContaServiceApp(IContaService Service,IUnitOfWork unitOfWork,IMapper mapper) : base(Service, mapper, unitOfWork)
        {
        }
        public override async Task<Conta> Add(Conta TEntity, bool saveChanges = true)
        {
            try
            {
                var conta = await _Service.GetFirstOrDefault(p=>p.Email == TEntity.Email);
                if (conta is not null)
                {
                    throw new Exception("Ja existe uma conta com esse Email");
                }
            }
            catch (Exception )
            {

                throw;
            }
            
            return await base.Add(TEntity, saveChanges);
        }

    }
}
