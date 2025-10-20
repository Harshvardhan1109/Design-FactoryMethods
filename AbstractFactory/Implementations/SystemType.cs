using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    public class LaptopSystemType : ISystemType
    {
        public String GetSystem()
        {
            return SystemType.Laptop.ToString();
        }
    }

    public class DesktopSystemType : ISystemType
    {
        public String GetSystem()
        {
            return SystemType.Desktop.ToString();
        }
    }
}
