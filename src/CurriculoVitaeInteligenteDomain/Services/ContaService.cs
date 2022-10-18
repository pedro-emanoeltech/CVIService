using CurriculoVitaeInteligenteDomain.Content.Enums;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;


namespace CurriculoVitaeInteligenteDomain.Services
{
    public class ContaService : BaseService<Conta>, IContaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContaRepository _repository;
        public ContaService(IContaRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {   
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<Conta> AdicionarConta(CancellationToken stoppingToken)
        {

          
                try
                {
                    var conta3 = await this.GetFirstOrDefault(p => p.Status == Status.Inativo);

                //            //conta3.Id = Guid.NewGuid();
                //            //conta3.Email = "josefino@hotmail.com";
                //            //conta3.Status = Status.Ativo;
                //            //await this.Add(conta3);


                //            Conta conta = new Conta();
                //            conta.Id = Guid.NewGuid();
                //            conta.Email = "josefino@hotmail2.com";
                //            conta.Senha = "vtp-123p";
                //            conta.DateCreate = DateTime.Now;
                //            conta.DateUpdate = DateTime.Now;
                //            conta.TipoPerfil = TipoPerfil.CNPJ;
                //            conta.Status = Status.Inativo;
                //            await this.Add(conta);
                //            await _unitOfWork.Commit();
                //            return conta;
                //        }
                //        catch (Exception e)
                //        {
                //            await _unitOfWork.Rollback();
                //            throw;
                //        }



                ////IList<Conta> conta1 = new IList<Conta>;
                //var conta1 = await this.GetList();
                //Conta conta2 = new Conta();
                //Conta conta3 = new Conta();

                //for (int i = 0; i < conta1.Count; i++)
                //{
                //    conta2 = await this.Get(conta1[i].Id.ToString()!);

                //}
                //conta3 = await this.GetFirstOrDefault(p => p.Status == Status.Inativo);

                //if (conta3 != null)
                //{
                //    await this.Remove(conta3.Id!.ToString());
                //}
                //conta2.TipoPerfil = TipoPerfil.CNPJ;
                //await this.Edit(conta2);

                //var conta4 = await this.GetToList(p => p.TipoPerfil == TipoPerfil.CNPJ);
                //{

                //}

                return conta3;

                }
                catch (Exception)
                {

                    throw;
                }




            
        }   
    }


}
