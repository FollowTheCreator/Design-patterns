using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.Facade
{
    class VideoFile
    {
        public string Filename { get; private set; }

        public VideoFile(string Filename)
        {
            this.Filename = Filename;
        }
    }
}
