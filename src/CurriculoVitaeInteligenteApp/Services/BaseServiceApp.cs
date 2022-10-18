using CurriculoVitaeInteligenteApp.Interfaces;
using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteDomain.Interfaces.Services;
using System.Linq.Expressions;

namespace CurriculoVitaeInteligenteApp.Services
{
    public class BaseServiceApp<T> : IBaseServiceApp<T> where T : ClassBase, IAddContextBaseProperty
    {
        private readonly IBaseService<T> _Service;

        protected readonly IUnitOfWork _unitOfWork;

        protected BaseServiceApp(IBaseService<T> Service, IUnitOfWork unitOfWork)
        {
            _Service = Service;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> Add(T TEntity, bool saveChanges = true)
        {
            return await _Service.Add(TEntity, saveChanges);
        }

        public async Task<T?> Get(string id)
        {
            return await _Service.Get(id);
        }

        public async Task<IList<T>> GetList()
        {
            return await _Service.GetList();
        }

        public async Task<bool> Remove(string id)
        {
            return await _Service.Remove(id);
        }

        public async Task<T> Edit(T TEntity)
        {
            try
            {
                return await _Service.Edit(TEntity);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<T?> GetFirstOrDefault(Expression<Func<T, bool>>? condicao = null)
        {
            try
            {
                return await _Service.GetFirstOrDefault(condicao);
            }
            catch
            {
                return null;
            }
        }

        public async Task<IList<T>?> GetToList(Expression<Func<T, bool>>? condicao = null)
        {
            try
            {
                return await _Service.GetToList(condicao);
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

