﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;
using ITechart.Patterns.Singleton.DbContexts;
using ITechart.Patterns.Singleton.Models;
using ITechart.Patterns.Singleton;
using System.Xml;
using ITechart.Patterns.Adapter;
using ITechart.Patterns.Proxy;
using ITechart.Patterns.Facade;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSample("Abstract factory", () => {
                AbstractFactoryUsage exampleAbstractFactoryUsage = new AbstractFactoryUsage();
                exampleAbstractFactoryUsage.UseAbstractFactory();
            });

            RunSample("Adapter", AdapterUsage.UseAdapter);
            
            RunSample("Facade", FacadeUsage.UseFacade);

            RunSample("Proxy", ProxyUsage.UseProxy);

            RunSample("Singleton", SingletonUsage.UseSingleton);



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
