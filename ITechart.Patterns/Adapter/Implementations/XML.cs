using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;

namespace ITechart.Patterns.Adapter.Implementations
{
    class XML : IXML
    {
        public string Path { get; set; }

        public XML(string Path)
        {
            this.Path = Path;
        }

        public string GetXMLPath()
        {
            return Path;
        }
    }
}
