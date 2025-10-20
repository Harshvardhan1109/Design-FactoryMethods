using AbstractFactory.Enums;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    public class I5Processor : IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I5.ToString();
        }
    }

    public class I7Processor:IProcessor
    {
        public string GetProcessor()
        {
            return Processor.I7.ToString();
        }
    }
}
