using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class ExtraCarFactory : ICarFactory
    {
        public IEngine CreateEngine()
        {
            return new ExtraEngine();
        }
        public IWheels CreateWheels()
        {
            return new ExtraWheels();
        }
        public ISuspension CreateSuspension()
        {
            return new ExtraSuspension();
        }
    }
}
