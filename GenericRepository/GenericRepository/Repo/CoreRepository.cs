using GenericRepository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repo
{
    public class CoreRepository<TEntity, TContext> : IRepository<TEntity>
            where TEntity : class, IEntity
            where TContext : DbContext
    {
        private readonly DbContext _context;

        public CoreRepository(DbContext context)
        {
            this._context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var data = await _context.Set<TEntity>().FindAsync(id);
            if (data == null)
            {
                return data;
            }

            _context.Set<TEntity>().Remove(data);
            await _context.SaveChangesAsync();
            return data;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
