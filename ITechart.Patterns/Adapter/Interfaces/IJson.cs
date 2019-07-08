using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.Adapter.Interfaces
{
    interface IJson
    {
        string Path { get; set; }

        string GetJsonPath();
    }
}
