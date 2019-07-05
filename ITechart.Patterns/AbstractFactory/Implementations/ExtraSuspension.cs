using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.AbstractFactory.Interfaces;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class ExtraSuspension : Suspension, ISuspension
    {
        public string DescribeSuspension()
        {
            return GetDescription("Extra");
        }
    }
}
