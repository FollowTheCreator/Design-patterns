﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechart.Patterns.Facade.Interfaces;

namespace ITechart.Patterns.Facade
{
    class VideoConverter
    {
        public static string Convert(VideoFile file, ICodec codec)
        {
            return codec.Convert(file);
        }
    }
}
