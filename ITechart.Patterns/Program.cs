﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory;

namespace ITechart.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryUsage ExampleAbstractFactoryUsage = new AbstractFactoryUsage();
            ExampleAbstractFactoryUsage.UseAbstractFactory();
        }
    }
}
