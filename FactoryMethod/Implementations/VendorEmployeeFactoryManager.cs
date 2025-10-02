using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Implementations
{
    internal class VendorEmployeeFactoryManager : EmployeeFactoryManager
    {
        public VendorEmployeeFactoryManager(Employee emp) : base(emp)
        {
        }

        public override decimal GetBonus()
        {
            return Convert.ToDecimal(100000.25);
        }

        public override decimal GetSalary()
        {
            return Convert.ToDecimal(6.25);
        }

        public decimal GetHomeAllowance()
        {
            return Convert.ToDecimal(5000);
        }
    }
}
