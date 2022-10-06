using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace CurriculoVitaeInteligenteDomain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class , IAddContextBaseProperty
    {
      public Task<T> Add(T Entity, bool saveChanges = true);
      public Task<T?> Get(string id);
      public Task<IList<T>> GetList();
      public Task<bool> Remove(string id);
      public Task<T> Edit(T Entity);
      public Task<T?> GetFirstOrDefault(Expression<Func<T, bool>>? condicao = null);
      public Task<IList<T>?> GetToList(Expression<Func<T, bool>>? condicao = null);
       
    }
}
