using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Proxy.Models;

namespace ITechart.Patterns.Proxy.Interfaces
{
    interface IYesterdayRate
    {
        ExchangeRate GetRate(int id);
    }
}
