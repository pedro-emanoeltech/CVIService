using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using System.Linq.Expressions;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Services
{
    public interface IBaseService<T> where T : ClassBase, IAddContextBaseProperty
    {
        Task<T> Add(T Entity, bool saveChanges = true);
        Task<T?> Get(string id);
        Task<IList<T>> GetList();
        Task<bool> Remove(string id);
        Task<T> Edit(T Entity);
        Task<T?> GetFirstOrDefault(Expression<Func<T, bool>>? condicao = null);
        Task<IList<T>?> GetToList(Expression<Func<T, bool>>? condicao = null);
       
    }
}
