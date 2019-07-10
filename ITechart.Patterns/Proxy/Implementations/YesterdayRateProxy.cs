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
        private readonly List<ExchangeRate> rates;

        private readonly IYesterdayRate yesterdayRate;

        public YesterdayRateProxy(IYesterdayRate yesterdayRate)
        {
            this.yesterdayRate = yesterdayRate;
            rates = new List<ExchangeRate>();
        }

        public ExchangeRate GetRate(int id)
        {
            ExchangeRate rate = rates.FirstOrDefault(item => item.Id == id);
            if (rate == null)
            {
                rate = yesterdayRate.GetRate(id);
                if(rate != null)
                {
                    rates.Add(rate);
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
