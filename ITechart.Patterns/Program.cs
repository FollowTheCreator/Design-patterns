using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;
using ITechart.Patterns.Adapter;
using ITechart.Patterns.Facade;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Abstract factory");
            AbstractFactoryUsage ExampleAbstractFactoryUsage = new AbstractFactoryUsage();
            ExampleAbstractFactoryUsage.UseAbstractFactory();

            Console.WriteLine("\n--Adapter");
            AdapterUsage.UseAdapter();
            Console.WriteLine("\n--Facade");
            FacadeUsage.UseFacade();
            Console.ReadKey();
        }
    }
}
