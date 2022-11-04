using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class EnderecoServiceApp : BaseServiceApp<Endereco>, IEnderecoServiceApp
    {
        public EnderecoServiceApp(IEnderecoService service,IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
        }
       
    }
}
