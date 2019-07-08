using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Facade.Interfaces;
using ITechart.Patterns.Facade.Codecs;

namespace ITechart.Patterns.Facade
{
    class SimpleConverter
    {
        public static string Convert(string fileName, string format)
        {
            var videoFile = new VideoFile(fileName);
            if(format == "OGG")
            {
                return VideoConverter.Convert(videoFile, new OGGCodec());
            }
            return VideoConverter.Convert(videoFile, new MPEG4Codec());
        }
    }
}
