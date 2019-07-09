using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Proxy.Models;
using Newtonsoft.Json;

namespace ITechart.Patterns.Proxy
{
    class ExternalResource
    {
        public static List<ExchangeRate> GetRates()
        {
            string json = @"
            [
            {
                'Id': 1,
                'Rate': 28,
            },
            {
                'Id': 2,
                'Rate': 214,
            },
            {
                'Id': 3,
                'Rate': 7,
            }
            ]";
            return JsonConvert.DeserializeObject<List<ExchangeRate>>(json);
        }
    }
}
