using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    public class MacBrand : IBrand
    {
        public string GetBrand()
        {
            return Brand.Mac.ToString();
        }
    }
    public class DellBrand:IBrand
    {
        public string GetBrand()
        {
            return Brand.Dell.ToString();
        }
    }
}
