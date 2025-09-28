using SimpleFactory.Implementation;
using SimpleFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace SimpleFactory.Factories
{
    public class EmployeeSimpleFactory
    {
        public EmployeeSimpleFactoryManager GetEmpoyeeManager(Employee emp)
        {
            if (Convert.ToString(emp.EmploymentTypeId) == "626D0659-BF59-49A3-8B06-C59B59DF5A1E")
                return new PermanentEmployee(emp);
            else
                return new VendorEmployee(emp);
        }
    }
}
