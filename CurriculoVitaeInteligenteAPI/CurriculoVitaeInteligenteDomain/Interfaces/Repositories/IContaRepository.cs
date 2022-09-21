﻿using CurriculoVitaeInteligenteDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoVitaeInteligenteDomain.Interfaces.Repositories
{
    public interface IContaRepository
    {
        public Task<Conta> Add(Conta conta, bool saveChanges = true);
        public Task<Conta?> Get(string id);
        public Task<IList<Conta>> GetList();
        public Task<bool> Remove(string id);
        public Task<Conta> Edit(Conta conta);
        public Task<Conta?> GetFirstOrDefault(Expression<Func<Conta, bool>>? condicao = null);
        public Task<IList<Conta>?> GetToList(Expression<Func<Conta, bool>>? condicao = null);


    }
}