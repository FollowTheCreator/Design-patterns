using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Adapter.Interfaces;

namespace ITechart.Patterns.Adapter.Implementations
{
    class Json : IJson
    {
        public string Path { get; set; }

        public Json(string Path)
        {
            this.Path = Path;
        }

        public string GetJsonPath()
        {
            return Path;
        }
    }
}
