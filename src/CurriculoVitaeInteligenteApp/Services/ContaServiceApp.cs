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
    }
}
