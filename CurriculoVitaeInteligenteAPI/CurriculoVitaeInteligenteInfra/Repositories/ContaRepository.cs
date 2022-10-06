using CurriculoVitaeInteligenteDomain.Entities;
using CurriculoVitaeInteligenteDomain.Interfaces.Repositories;
using CurriculoVitaeInteligenteInfra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteInfra.Repositories
{
    
    public class ContaRepository : BaseRepository<Conta>,IBaseRepository
    {
        protected readonly CVIContext _context;

        public ContaRepository(CVIContext context)
        {
            _context = context;
        }
    
        public async Task<Conta> Add(Conta conta, bool saveChanges = true)
        {
            try
            {
                
                await _context.AddAsync(conta);
                if (saveChanges)
                {
                    await _context.SaveChangesAsync();
                }
                return conta;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Conta?> Get(string id)
        {
            try
            {
                if (id == null)
                {
                    return null;
                }
                var conta = await _context.Conta!.FirstOrDefaultAsync(m => m.Id == Guid.Parse(id));

                return conta;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IList<Conta>> GetList()
        {
            try
            {
                var lista = await _context.Conta!.Where(e => e.Id != Guid.Empty).ToListAsync<Conta>();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> Remove(string id)
        {
            try
            {
                if (id is not null)
                {
                    var conta = await _context.Conta.FirstOrDefaultAsync(c =>c.Id == Guid.Parse(id));
                    if (conta is not null )
                    {
                        _context.Remove(conta);
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

        public  async Task<Conta> Edit(Conta conta)
        {
            try
            {
                if (conta.Id is not null)
                {
                    _context.Update(conta);
                    await _context.SaveChangesAsync();
                  
                }
              
                return conta;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Conta?> GetFirstOrDefault( Expression<Func<Conta, bool>>? condicao = null)
        {
            try
            {
                IQueryable<Conta> queryable = _context.Conta!;
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
        
        public  async Task<IList<Conta>?> GetToList(Expression<Func<Conta, bool>>? condicao = null)
        {
            try
            {
                IQueryable<Conta> queryable = _context.Conta!;

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
