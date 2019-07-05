using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.AbstractFactory
{
    interface IEngine
    {
        void DescribeEngine();
    }
    interface IWheels
    {
        void DescribeWheels();
    }
    interface ISuspension
    {
        void DescribeSuspension();
    }
    class EconomicEngine : IEngine
    {
        public void DescribeEngine()
        {
            Console.WriteLine("Engine type: Economic.");
        }
    }
    class StandartEngine : IEngine
    {
        public void DescribeEngine()
        {
            Console.WriteLine("Engine type: Standart.");
        }
    }
    class ExtraEngine : IEngine
    {
        public void DescribeEngine()
        {
            Console.WriteLine("Engine type: Extra.");
        }
    }
    class EconomicWheels : IWheels
    {
        public void DescribeWheels()
        {
            Console.WriteLine("Wheels diameter: 15 inches.");
        }
    }
    class StandartWheels : IWheels
    {
        public void DescribeWheels()
        {
            Console.WriteLine("Wheels diameter: 19 inches.");
        }
    }
    class ExtraWheels : IWheels
    {
        public void DescribeWheels()
        {
            Console.WriteLine("Wheels diameter: 23 inches.");
        }
    }
    class EconomicSuspension : ISuspension
    {
        public void DescribeSuspension()
        {
            Console.WriteLine("Suspension: Economic.");
        }
    }
    class StandartSuspension : ISuspension
    {
        public void DescribeSuspension()
        {
            Console.WriteLine("Suspension: Standart.");
        }
    }
    class ExtraSuspension : ISuspension
    {
        public void DescribeSuspension()
        {
            Console.WriteLine("Suspension: Extra.");
        }
    }
    interface ICarFactory
    {
        IEngine CreateEngine();
        IWheels CreateWheels();
        ISuspension CreateSuspension();
    }
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
    class Car
    {
        private IEngine engine;
        public IEngine Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }
        private IWheels wheels;
        public IWheels Wheels
        {
            get
            {
                return wheels;
            }
            set
            {
                wheels = value;
            }
        }
        private ISuspension suspension;
        public ISuspension Suspension
        {
            get
            {
                return suspension;
            }
            set
            {
                suspension = value;
            }
        }
        public Car(ICarFactory CarFactory)
        {
            engine = CarFactory.CreateEngine();
            wheels = CarFactory.CreateWheels();
            suspension = CarFactory.CreateSuspension();
        }
        public void DescribeCar()
        {
            engine.DescribeEngine();
            wheels.DescribeWheels();
            suspension.DescribeSuspension();
        }
    }
}
