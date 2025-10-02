using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Interfaces
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp) {
            _emp = emp;
        }

        public Employee GetSalaryDetails()
        {
            EmployeeFactoryManager emp = this.Create();
            _emp.BonusPercentage = emp.GetBonus();
            _emp.Salary = emp.GetSalary();              
            return _emp;
        }
        public abstract EmployeeFactoryManager Create();

    }
}
