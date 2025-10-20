using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.Infrastructure.Models;

namespace AbstractFactory.Factories
{
    public class ComputerAbstractFactory
    {
        public IComputerFactory GetComputerFactory(Employee emp)
        {
            IComputerFactory computerFactory = null;
            if(emp.EmploymentTypeId== Guid.Parse("626D0659-BF59-49A3-8B06-C59B59DF5A1E"))//Permanent
            {
                if (emp.RoleId == Guid.Parse("AA2EA489-CAF7-4735-A8E1-4539C34C7917"))//Manager
                {
                    computerFactory = new MACDesktopFactory();
                }
                else //Anyone else
                {
                    computerFactory = new MACLaptopFactory();
                }
            }
            else if (emp.EmploymentTypeId == Guid.Parse("2064EF03-6483-4D71-8E0F-88C1BE3B1D29"))//Vendor
            {
                if (emp.RoleId == Guid.Parse("AA2EA489-CAF7-4735-A8E1-4539C34C7917"))//Manager
                {
                    computerFactory = new DellDesktopFactory();
                }
                else //Any one else
                {
                    computerFactory = new DellLaptopFactory();
                }
            }
            return computerFactory;
        }
    }
}
