using DesignPatternPractice.StategyPattern.Compressors;
using DesignPatternPractice.StategyPattern.Filters;

namespace DesignPatternPractice.StategyPattern
{
    public class ImageStorage
    {
        private ICompressor _compressor;
        private IFilter _filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void store(string file)
        {
            _filter.Apply(ref file);
            _compressor.compress(ref file);

            $"File ({file}) is now stored".Dump();
        }
    }
}
