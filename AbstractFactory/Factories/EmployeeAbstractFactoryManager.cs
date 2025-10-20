using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class EmployeeAbstractFactoryManager
    {
        private readonly IComputerFactory _computerFactory=null;
        public EmployeeAbstractFactoryManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }
        
        public String GetSystemDetails()
        {
            IBrand brand = _computerFactory.Brand();
            IProcessor processor = _computerFactory.Processor();
            ISystemType systemType = _computerFactory.SystemType();

            return $"{brand.GetBrand()}; {processor.GetProcessor()}; {systemType.GetSystem()};";            
        }
         
    }
}
