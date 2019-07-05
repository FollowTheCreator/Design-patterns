using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.AbstractFactory.Implementations
{
    class Engine
    {
        protected string GetDescription(string type)
        {
            return $"Engine type: {type}";
        }
    }
}
