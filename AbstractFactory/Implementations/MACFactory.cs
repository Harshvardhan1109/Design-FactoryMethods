using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    public class MACDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MacBrand();
        }

        public IProcessor Processor()
        {
            return new I7Processor();
        }

        public virtual ISystemType SystemType()
        {
            return new DesktopSystemType();
        }
    }

    public class MACLaptopFactory : MACDesktopFactory
    {
        public override ISystemType SystemType()
        {
            return new LaptopSystemType();
        }
    }
}
