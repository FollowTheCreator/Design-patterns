using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;

namespace ITechart.Patterns.Adapter.Implementations
{
    class Xml : IXml
    {
        public string Value { get; set; }

        public Xml(string value)
        {
            Value = value;
        }
    }
}
