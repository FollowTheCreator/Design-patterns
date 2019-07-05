using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class Wheels
    {
        protected string GetDescription(string diameter)
        {
            return $"Wheels diameter: {diameter}";
        }
    }
}
