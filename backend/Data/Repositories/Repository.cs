using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public async Task<TEntity> Get(int id)
        {
            return await _entities.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return await _entities.SingleOrDefaultAsync(predicate);
        }

        //TODO: add synchronous methods and rename async methods e.g. Add -> AddAsync
        public virtual async Task Add(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

    }
}