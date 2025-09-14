using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;
using UOW.Infrastructure.RepositoryInterfaces;

namespace UOW.Infrastructure.RepositoryImplementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _dbContext;
        public IEmployeeRepository _employeeRepository { get; }

        public UnitOfWork(IEmployeeRepository employeeRepository, DBContext dbContext)
        {
            _employeeRepository = employeeRepository;
            _dbContext = dbContext;
        }
        public async Task<int> Save()
        {
            return await _dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
