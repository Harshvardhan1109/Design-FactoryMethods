using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace SimpleFactory.Interface
{
    public abstract class EmployeeSimpleFactoryManager
    {
        protected Employee _employee;
        protected EmployeeSimpleFactoryManager(Employee employee)
        {
            _employee = employee;
        }
        public abstract decimal CalculateBonus();
        public abstract decimal CalcualteSalary();
    }
}
