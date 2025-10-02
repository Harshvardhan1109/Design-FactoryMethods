using FactoryMethod.Implementations;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace FactoryMethod.Factories
{
    public class EmployeeFactory
    {
        public BaseEmployeeFactory Create(Employee emp)
        {
            if (Convert.ToString(emp.EmploymentTypeId) == "626D0659-BF59-49A3-8B06-C59B59DF5A1E")
                return new PermanentBaseEmployeeFactory(emp);
            else
                return new VendorBaseEmployeeFactory(emp);
        }
    }
}
