using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using System.Linq.Expressions;

namespace CurriculoVitaeInteligenteApp.Interfaces
{
    public interface IBaseServiceApp<T> where T : ClassBase
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
