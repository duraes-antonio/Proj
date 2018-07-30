using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Proj.Aplicacao.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        T Adicionar(T entidade);
        
        void Atualizar(T entidade);

        IEnumerable<T> ObterTodos();

        T ObterPorId(int id);

        IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado);

        void Remover(T entidade);
    }
}