using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Implementations
{
    public class PermanentBaseEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentBaseEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override EmployeeFactoryManager Create()
        {
            PermanentEmployeeFactoryManager perm = new PermanentEmployeeFactoryManager(_emp);
            _emp.MedicalAllowance = perm.GetMedicalAllowance();
            return perm;
        }
    }
}
