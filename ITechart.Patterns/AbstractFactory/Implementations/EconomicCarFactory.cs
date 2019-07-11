using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class EconomicCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new EconomicEngine();
        }

        public IWheels CreateWheels()
        {
            return new EconomicWheels();
        }

        public ISuspension CreateSuspension()
        {
            return new EconomicSuspension();
        }
    }
}
