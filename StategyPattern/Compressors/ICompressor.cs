namespace DesignPatternPractice.StategyPattern.Compressors
{
    public interface ICompressor
    {
        // Using string instead of byte[] is easier for example
        //byte[] compress(byte[] image);
        void compress(ref string file);
    }
}
