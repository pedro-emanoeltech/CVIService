using CurriculoVitaeInteligenteDomain.Entities;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Services
{
    public interface IContaService : IBaseService<Conta>
    {
        Task<Conta> AdicionarConta(CancellationToken stoppingToken);
        Task<Conta> Authenticate(Conta TEntity);
    }
}
