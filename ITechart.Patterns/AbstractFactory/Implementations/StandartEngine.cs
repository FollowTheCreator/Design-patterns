using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class StandartEngine : Engine, IEngine
    {
        public string DescribeEngine()
        {
            return GetDescription("Standart");
        }
    }
}
