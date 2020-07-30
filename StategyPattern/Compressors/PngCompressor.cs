namespace DesignPatternPractice.StategyPattern.Compressors
{
    public class PngCompressor : ICompressor
    {
        public void compress(ref string file)
        {
            ("Compressing Using Png to file " + file).Dump();
            file += " Compressed";
        }
    }
}
