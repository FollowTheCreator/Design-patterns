using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Implementations;

namespace ITechart.Patterns.AbstractFactory
{
    class AbstractFactoryUsage
    {
        public void UseAbstractFactory()
        {
            Car MyCar = new Car(new EconomicCarFactory());
            Console.WriteLine($"Economic car description: {MyCar.DescribeCar()}");
            MyCar = new Car(new StandartCarFactory());
            Console.WriteLine($"\nStandart car description: {MyCar.DescribeCar()}");
            MyCar = new Car(new ExtraCarFactory());
            Console.WriteLine($"\nExtra car description: {MyCar.DescribeCar()}");
        }
    }
}
