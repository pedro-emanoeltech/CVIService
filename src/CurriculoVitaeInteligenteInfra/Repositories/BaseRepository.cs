using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Data.Entity;
using CurriculoVitaeInteligenteDomain.Entities.Interfaces;
using System.Data;
using CurriculoVitaeInteligenteDomain.Entities;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
   public abstract class BaseRepository<T> : IBaseRepository<T> where T : ClassBase, IAddContextBaseProperty
    {
        protected readonly CVIContext _context;

        protected BaseRepository(CVIContext context) => 
            _context = context;

        public virtual async Task<T> Add(T TEntity, bool saveChanges = true)
        {
            try
            {
                await _context.Set<T>().AddAsync(TEntity);
                if (saveChanges)
                {
                    await _context.SaveChangesAsync();
                }
                return TEntity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual async Task<T?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    return null;
                }
                T TEntity = await _context.Set<T>().FirstOrDefaultAsync((T m) => m.Id == Guid.Parse(id));

                return TEntity;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual  async Task<IList<T>> GetList()
        {
            try
            {
                var lista = await _context.Set<T>()!.Where(e => e.Id != Guid.Empty).ToListAsync<T>();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public virtual async Task<bool> Remove(string id)
        {
            try
            {
                if (id is not null)
                {
                    var TEntity = await _context.Set<T>().FirstOrDefaultAsync(c => c.Id == Guid.Parse(id));
                    if (TEntity is not null)
                    {
                        _context.Set<T>().Remove(TEntity);
                        await _context.SaveChangesAsync();
                        return true;

                    }

                    return false;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public virtual async Task<T> Edit(T TEntity)
        {
            try
            {
                
                _context.Entry(TEntity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

               
                _context.Set<T>().Update(TEntity);
                 await _context.SaveChangesAsync();

                    

                return TEntity;
               
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
                IQueryable<T> queryable = _context.Set<T>()!;
                if (condicao != null)
                {
                    queryable = queryable.Where(condicao);
                }
                return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(queryable);
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
                IQueryable<T> queryable = _context.Set<T>()!;

                if (condicao != null)
                {
                    queryable = queryable.Where(condicao);
                }
                return await EntityFrameworkQueryableExtensions.ToListAsync(queryable);
            }
            catch
            {
                return null;
            }
        }

    }
}
