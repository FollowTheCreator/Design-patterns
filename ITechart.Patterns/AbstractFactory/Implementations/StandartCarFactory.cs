using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class StandartCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new StandartEngine();
        }
        public IWheels CreateWheels()
        {
            return new StandartWheels();
        }
        public ISuspension CreateSuspension()
        {
            return new StandartSuspension();
        }
    }
}
