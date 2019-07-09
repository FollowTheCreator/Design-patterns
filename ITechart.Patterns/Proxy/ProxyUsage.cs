using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Proxy.Models;
using ITechart.Patterns.Proxy.Interfaces;
using ITechart.Patterns.Proxy.Implementations;

namespace ITechart.Patterns.Proxy
{
    class ProxyUsage
    {
        public static void UseProxy()
        {
            IYesterdayRate rates = new YesterdayRateProxy();
            ExchangeRate firstRate = rates.GetRate(1);
            Console.WriteLine($"Rate: {firstRate.Rate}, Source: {firstRate.Source}");

            ExchangeRate secondRate = rates.GetRate(2);
            Console.WriteLine($"Rate: {secondRate.Rate}, Source: {secondRate.Source}");

            ExchangeRate thirdRate = rates.GetRate(1);
            Console.WriteLine($"Rate: {thirdRate.Rate}, Source: {thirdRate.Source}");
        }
    }
}
