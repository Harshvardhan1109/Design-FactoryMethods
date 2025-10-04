using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;
using UOW.Infrastructure.RepositoryInterfaces;

namespace UOW.Infrastructure.RepositoryImplementation
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MyDbContext _dbContext;
        protected GenericRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(Guid Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
    }
}
