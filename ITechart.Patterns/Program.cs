using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;
using ITechart.Patterns.Singleton.DbContexts;
using ITechart.Patterns.Singleton.Models;
using ITechart.Patterns.Singleton;
using ITechart.Patterns.Facade;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSample("Singleton", SingletonUsage.UseSingleton);

            RunSample("Facade", FacadeUsage.UseFacade);

            Console.ReadKey();
        }

        private static void RunSample(string name, Action action)
        {
            Console.WriteLine("--{0}", name);
            action();
            Console.WriteLine();
        }
    }
}
