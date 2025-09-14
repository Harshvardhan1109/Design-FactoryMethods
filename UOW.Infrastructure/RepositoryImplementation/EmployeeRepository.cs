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
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
