using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.Proxy.Models
{
    class ExchangeRate
    {
        public int Id { get; set; }

        public int Rate { get; set; }

        public string Source { get; set; }
    }
}
