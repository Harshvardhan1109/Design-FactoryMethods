using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace SimpleFactory.Interface
{
    public abstract class EmployeeManager
    {
        protected Employee _employee;
        protected EmployeeManager(Employee employee)
        {
            _employee = employee;
        }
        public abstract decimal CalculateBonus();
        public abstract decimal CalcualteSalary();
    }
}
