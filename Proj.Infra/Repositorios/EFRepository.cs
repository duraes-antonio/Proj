using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Proj.Aplicacao.Interfaces;
using Proj.Infra.Dados;

namespace Proj.Infra.Repositorios
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly ProjContexto _dbContexto;

        public EFRepository(ProjContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }
        
        public virtual T Adicionar(T entidade)
        {
            _dbContexto.Set<T>().Add(entidade);
            _dbContexto.SaveChanges();
            
            return entidade;
        }

        public virtual void Atualizar(T entidade)
        {
            _dbContexto.Entry(entidade).State = EntityState.Modified;
            _dbContexto.SaveChanges();
        }
        
        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            return _dbContexto.Set<T>().Where(predicado).AsEnumerable();
        }
        
        public virtual T ObterPorId(int id)
        {
            return _dbContexto.Set<T>().Find(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _dbContexto.Set<T>().AsEnumerable();
        }
        
        public void Remover(T entidade)
        {
            _dbContexto.Set<T>().Remove(entidade);
            _dbContexto.SaveChanges();
        }
    }
}