using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;
using ITechart.Patterns.Proxy;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Proxy");
            ProxyUsage.UseProxy();
            Console.ReadKey();
        }
    }
}
