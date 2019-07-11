using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Implementations;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory
{
    class AbstractFactoryUsage
    {
        public void UseAbstractFactory()
        {
            CreateAndDescribe("Economic car description:", new EconomicCarFactory());

            CreateAndDescribe("Standart car description:", new EconomicCarFactory());

            CreateAndDescribe("Extra car description:", new EconomicCarFactory());
        }

        private void CreateAndDescribe(string message, ICarFactory carFactory)
        {
            var car = new Car(carFactory);
            Console.WriteLine($"{message} {car.DescribeCar()}");
        }
    }
}
