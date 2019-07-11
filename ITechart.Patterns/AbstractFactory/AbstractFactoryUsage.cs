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
            Car myCar = new Car(new EconomicCarFactory());
            Console.WriteLine($"Economic car description: {myCar.DescribeCar()}");
            myCar = new Car(new StandartCarFactory());
            Console.WriteLine($"\nStandart car description: {myCar.DescribeCar()}");
            myCar = new Car(new ExtraCarFactory());
            Console.WriteLine($"\nExtra car description: {myCar.DescribeCar()}");
        }
    }
}
