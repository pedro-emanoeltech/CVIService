using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using System.Linq.Expressions;

namespace CurriculoVitaeInteligenteDomain.Services
{
    public abstract class BaseService<T>: IBaseService<T> where T : ClassBase, IAddContextBaseProperty
    {
        private readonly IBaseRepository<T> _repositorio;

        protected readonly IUnitOfWork _unitOfWork;

        protected BaseService(IBaseRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repositorio = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> Add(T TEntity, bool saveChanges = true)
        {
            return await _repositorio.Add(TEntity, saveChanges);
        }

        public async Task<T?> Get(string id)
        {
            return await _repositorio.Get(id);
        }

        public virtual  async Task<IList<T>> GetList()
        {
            return await _repositorio.GetList();
        }

        public async Task<bool> Remove(string id)
        {
           return await _repositorio.Remove(id);
        }

        public async Task<T> Edit(string id, T TEntity)
        {
            try
            {
                return await _repositorio.Edit( id, TEntity);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public virtual async Task<T?> GetFirstOrDefault(Expression<Func<T, bool>>? condicao = null)
        {
            try
            {
                return await _repositorio.GetFirstOrDefault(condicao);
            }
            catch
            {
                return null;
            }
        }

        public virtual async Task<IList<T>?> GetToList(Expression<Func<T, bool>>? condicao = null)
        {
            try
            {
                return await _repositorio.GetToList(condicao);
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}
