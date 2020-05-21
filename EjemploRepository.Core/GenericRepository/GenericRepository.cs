using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EjemploRepository.Core
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T> where T : class where C : DbContext
    {
        protected C Context;
        public GenericRepository(C context)
        {
            Context = context;
        }

        public virtual async Task<T> GetById(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<T> Add(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual void Save()
        {
            Context.SaveChangesAsync();
        }
    }
}