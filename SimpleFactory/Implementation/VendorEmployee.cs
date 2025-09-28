using SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace SimpleFactory.Implementation
{
    public class VendorEmployee : EmployeeManager
    {
        public VendorEmployee(Employee employee) : base(employee)
        {
        }

        public override decimal CalcualteSalary()
        {
            return Convert.ToDecimal(100000.50);
        }

        public override decimal CalculateBonus()
        {
            return Convert.ToDecimal(5.5);
        }
    }
}
