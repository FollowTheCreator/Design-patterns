using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Proxy.Interfaces;
using ITechart.Patterns.Proxy.Models;

namespace ITechart.Patterns.Proxy.Implementations
{
    class YesterdayRateProxy : IYesterdayRate
    {
        private readonly List<ExchangeRate> _rates;

        private readonly IYesterdayRate _yesterdayRate;

        public YesterdayRateProxy(IYesterdayRate yesterdayRate)
        {
            _yesterdayRate = yesterdayRate;
            _rates = new List<ExchangeRate>();
        }

        public ExchangeRate GetRate(int id)
        {
            ExchangeRate rate = _rates.FirstOrDefault(item => item.Id == id);

            if (rate == null)
            {
                rate = _yesterdayRate.GetRate(id);
                if(rate != null)
                {
                    _rates.Add(rate);
                    rate.Source = "External";
                }
            }
            else
            {
                rate.Source = "Cache";
            }

            return rate;
        }
    }
}
