using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Facade.Interfaces;

namespace ITechart.Patterns.Facade.Codecs
{
    class MPEG4Codec : ICodec
    {
        public string Convert(VideoFile file)
        {
            return $"{file.FileName} converted to MPEG4";
        }
    }
}
