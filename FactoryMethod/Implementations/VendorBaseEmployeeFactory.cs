using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Implementations
{
    public class VendorBaseEmployeeFactory : BaseEmployeeFactory
    {
        public VendorBaseEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override EmployeeFactoryManager Create()
        {
            VendorEmployeeFactoryManager vendor = new VendorEmployeeFactoryManager(_emp);
            _emp.HomeAllowance=vendor.GetHomeAllowance();
            return vendor;
        }
    }
}
