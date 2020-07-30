namespace DesignPatternPractice.StategyPattern.Compressors
{
    public class JpegCompressor : ICompressor
    {
        public void compress(ref string file)
        {
            ("Compressing Using Jpeg to file " + file).Dump();
            file += " Compressed";
        }
    }
}
