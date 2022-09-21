using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public class ContaService : IContaService
    {

        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository, IServiceProvider serviceProvider)
        {
            _contaRepository = contaRepository;
        }
        public async Task<Conta> Add(Conta conta, bool saveChanges = true)
        {
            return await _contaRepository.Add(conta, saveChanges);
        }

        public async Task<Conta> Edit(Conta conta)
        {
            return await _contaRepository.Edit(conta);
        }

        public async Task<Conta?> Get(string id)
        {
            return await _contaRepository.Get(id);
        }

        public async Task<Conta?> GetFirstOrDefault(Expression<Func<Conta, bool>>? condicao = null)
        {
            return await _contaRepository.GetFirstOrDefault(condicao);
        }

        public async Task<IList<Conta>> GetList()
        {
            return await _contaRepository.GetList();
        }

        public async Task<IList<Conta>?> GetToList(Expression<Func<Conta, bool>>? condicao = null)
        {
            return await _contaRepository.GetToList(condicao);
        }

        public async Task<bool> Remove(string id)
        {
            return await _contaRepository.Remove(id);
        }

        public async Task<Conta> AdicionarConta(CancellationToken stoppingToken)
        {

            try
            {
                Conta conta = new Conta();
                conta.Id = Guid.NewGuid();
                conta.Email = "Pedro.emanoeltech@hotmail.com";
                conta.Senha = "vtp-123p";
                conta.TipoPerfil = Content.Enums.TipoPerfil.CPF;
                await this.Add(conta);
                return conta;
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
            
        }
       
    }

 
}
