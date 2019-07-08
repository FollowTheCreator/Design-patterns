using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.AbstractFactory.Interfaces
{
    interface ICarFactory
    {
        IEngine CreateEngine();
        IWheels CreateWheels();
        ISuspension CreateSuspension();
    }
}
