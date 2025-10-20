using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    public class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DellBrand();
        }

        public IProcessor Processor()
        {
            return new I5Processor();
        }

        public virtual ISystemType SystemType()
        {
            return new DesktopSystemType();
        }
    }

    public class DellLaptopFactory : DellDesktopFactory
    {
        public override ISystemType SystemType()
        {
            return new LaptopSystemType();
        }
    }
}
