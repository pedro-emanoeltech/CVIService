using AutoMapper;
using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using CurriculoVitaeInteligenteDomain.Services;
using CVIServiceLibShared.App.Response;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class ContaServiceApp : BaseServiceApp<Conta>, IContaServiceApp
    {
        private readonly IContaService _Service;
        private readonly IMapper _mapper;
        public ContaServiceApp(IContaService service,IUnitOfWork unitOfWork, IMapper mapper) : base(service, mapper, unitOfWork)
        {
            _Service = service;
            _mapper = mapper;
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

        public async Task<AuthenticateResponse> Authenticate(Conta TEntity)
        {
            try
            {
                AuthenticateResponse authenticate = new AuthenticateResponse();
                var conta = await _Service.Authenticate(TEntity);
                if (conta.Email is not null)
                {

                    _mapper.Map(conta, authenticate);
                    var token = TokenService.GenerateToken(conta);
                    authenticate.Token = token;
                }
                else
                {
                    throw new Exception("Conta nao encontrada");
                }


                return authenticate;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }   
           
        }
    }
}
