using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechart.Patterns.Facade
{
    class VideoFile
    {
        public string FileName { get; private set; }

        public VideoFile(string fileName)
        {
            FileName = fileName;
        }
    }
}
