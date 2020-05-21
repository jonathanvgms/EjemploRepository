using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EjemploRepository.Core
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);

        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);

        Task<T> Add(T entity);

        Task<T> Remove(T entity);

        Task<T> Edit(T entity);

        void Save();
    }
}