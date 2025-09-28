using SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace SimpleFactory.Implementation
{
    public class PermanentEmployee : EmployeeSimpleFactoryManager
    {
        public PermanentEmployee(Employee employee) : base(employee)
        {
        }

        public override decimal CalcualteSalary()
        {
            return Convert.ToDecimal(200000.00);
        }

        public override decimal CalculateBonus()
        {
            return Convert.ToDecimal(11.99);
        }
    }
}
