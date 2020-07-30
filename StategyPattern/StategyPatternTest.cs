using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternPractice.StategyPattern.Compressors;
using DesignPatternPractice.StategyPattern.Filters;

namespace DesignPatternPractice.StategyPattern
{
    public static class StategyPatternTest
    {
        public static void Run()
        {
            var imgBaWJpegStorage = new ImageStorage(new JpegCompressor(), new BlackAndWhiteFilter());
            imgBaWJpegStorage.store("BabyPic");
            "============".Dump();
            var imgBaWPngStorage = new ImageStorage(new PngCompressor(), new BlackAndWhiteFilter());
            imgBaWPngStorage.store("ManPic");
        }
    }
}
