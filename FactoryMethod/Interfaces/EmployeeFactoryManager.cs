using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Interfaces
{
    public abstract class EmployeeFactoryManager
    {
        protected Employee _emp; 
        protected EmployeeFactoryManager(Employee emp) {
            _emp = emp;
        }
        public abstract Decimal GetSalary();
        public abstract Decimal GetBonus();
    }
}
