using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace UOW.Infrastructure.RepositoryInterfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}
