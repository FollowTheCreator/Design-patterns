using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;

namespace ITechart.Patterns.Adapter.Implementations
{
    class Json : IJson
    {
        public string Value { get; set; }

        public Json(string value)
        {
            this.Value = value;
        }
    }
}
