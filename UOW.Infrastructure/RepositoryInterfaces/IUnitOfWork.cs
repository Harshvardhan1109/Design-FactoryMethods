using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOW.Infrastructure.RepositoryInterfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IEmployeeRepository _employeeRepository { get; }
        Task<int> Save();
    }
}
