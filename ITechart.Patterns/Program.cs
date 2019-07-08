using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;
using ITechart.Patterns.Adapter;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Abstract factory");
            AbstractFactoryUsage ExampleAbstractFactoryUsage = new AbstractFactoryUsage();
            ExampleAbstractFactoryUsage.UseAbstractFactory();
            Console.WriteLine();

            Console.WriteLine("--Adapter");
            AdapterUsage.UseAdapter();

            Console.ReadKey();
        }
    }
}
