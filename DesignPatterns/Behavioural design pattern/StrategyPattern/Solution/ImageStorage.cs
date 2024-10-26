

namespace StrategyPattern.Solution
{
    internal class ImageStorage
    {
        public void Save(string fileName, ICompressor compressor, IFilter filter)
        {
            //delegating the work
            compressor.Compress();
            filter.ApplyFilter();

            Console.WriteLine("{0} Saved", fileName);
        }
    }
}
