using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class Car
    {
        public IEngine Engine { get; set;}

        public IWheels Wheels { get; set; }

        public ISuspension Suspension { get; set; }

        public Car(ICarFactory CarFactory)
        {
            Engine = CarFactory.CreateEngine();
            Wheels = CarFactory.CreateWheels();
            Suspension = CarFactory.CreateSuspension();
        }

        public string DescribeCar()
        {
            return $"\n{Engine.DescribeEngine()}\n{Wheels.DescribeWheels()}\n{Suspension.DescribeSuspension()}";
        }
    }
}
