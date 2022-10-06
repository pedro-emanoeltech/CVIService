using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Repositories
{
    public interface IBaseRepository
    {
        Task<Conta> Add(Conta conta, bool saveChanges = true);
        Task<Conta?> Get(string id);
        Task<IList<Conta>> GetList();
        Task<bool> Remove(string id);
        Task<Conta> Edit(Conta conta);
        Task<Conta?> GetFirstOrDefault(Expression<Func<Conta, bool>>? condicao = null);
        Task<IList<Conta>?> GetToList(Expression<Func<Conta, bool>>? condicao = null);
       
    }
}
