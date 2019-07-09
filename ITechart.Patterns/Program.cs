using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;
using ITechart.Patterns.Singleton.DbContexts;
using ITechart.Patterns.Singleton.Models;
using ITechart.Patterns.Singleton;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonUsage.UseSingleton();
            Console.ReadKey();
        }
    }
}
