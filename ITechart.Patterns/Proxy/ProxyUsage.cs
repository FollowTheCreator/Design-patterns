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
            IYesterdayRate rates = new YesterdayRateProxy(new YesterdayRate());
            WriteRate(rates.GetRate(1));

            WriteRate(rates.GetRate(2));

            WriteRate(rates.GetRate(15));

            WriteRate(rates.GetRate(1));
        }

        private static void WriteRate(ExchangeRate rate)
        {
            if (rate != null)
            {
                Console.WriteLine($"Rate: {rate.Rate}, Source: {rate.Source}");
            }
        }
    }
}
