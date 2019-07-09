using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.Facade
{
    class FacadeUsage
    {
        public static void UseFacade()
        {
            Console.WriteLine($"Convert to OGG: {SimpleConverter.Convert("MyFirstVideo", "OGG")}\nConvert to MPEG4: {SimpleConverter.Convert("MySecondVideo", "MPEG4")}");
        }
    }
}
