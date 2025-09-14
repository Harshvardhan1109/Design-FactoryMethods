using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOW.Infrastructure.RepositoryInterfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid Id);
    }
}
