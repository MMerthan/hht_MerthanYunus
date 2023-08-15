using MakineData.Context;
using MakineData.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MakineData.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly AppDbContext dbContext;

        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
                query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await dbContext.SaveChangesAsync(); // Değişikliği kaydetmek için SaveChangesAsync() metodu çağrılıyor.
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.SingleOrDefaultAsync(); // SingleAsync() yerine SingleOrDefaultAsync() kullanılmalı.
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            dbContext.Update(entity); // await Task.Run() kullanmaya gerek yok, çünkü Update() senkron bir metottur.
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            Table.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }
        IGenericRepository<T> IGenericRepository<T>.GetRepository<T>()
		{
			return new GenericRepository<T>(dbContext);
		}
	}
}
