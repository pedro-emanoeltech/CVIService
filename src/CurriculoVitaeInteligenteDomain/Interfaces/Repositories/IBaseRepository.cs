using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace CurriculoVitaeInteligenteDomain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : ClassBase, IAddContextBaseProperty
    {
       Task<T> Add(T Entity, bool saveChanges = true);
       Task<T?> Get(string id);
       Task<IList<T>> GetList();
       Task<bool> Remove(string id);
        Task<T> Edit(string id, T TEntity);
       Task<T?> GetFirstOrDefault(Expression<Func<T, bool>>? condicao = null);
       Task<IList<T>?> GetToList(Expression<Func<T, bool>>? condicao = null);
        
    }
}
