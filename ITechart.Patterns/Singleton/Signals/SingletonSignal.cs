using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.Singleton.Signals
{
    class SingletonSignal
    {
        public static void Signal()
        {
            Console.WriteLine("Already exist");
        }
    }
}
