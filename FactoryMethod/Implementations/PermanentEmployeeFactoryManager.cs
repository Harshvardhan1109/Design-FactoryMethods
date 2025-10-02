using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Implementations
{
    internal class PermanentEmployeeFactoryManager : EmployeeFactoryManager
    {
        public PermanentEmployeeFactoryManager(Employee emp) : base(emp)
        {
        }

        public override decimal GetBonus()
        {
            return Convert.ToDecimal(200000.50);
        }

        public override decimal GetSalary()
        {
            return Convert.ToDecimal(12.5);
        }

        public decimal GetMedicalAllowance()
        {
            return Convert.ToDecimal(10000.99);
        } 
    }
}
