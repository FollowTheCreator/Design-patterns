using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Proxy.Interfaces;
using ITechart.Patterns.Proxy.Models;

namespace ITechart.Patterns.Proxy.Implementations
{
    class YesterdayRate : IYesterdayRate
    {
        public ExchangeRate GetRate(int id)
        {
            return ExternalResource.GetRates().FirstOrDefault(item => item.Id == id);
        }
    }
}
