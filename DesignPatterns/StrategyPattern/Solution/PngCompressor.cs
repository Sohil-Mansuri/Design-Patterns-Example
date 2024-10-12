
namespace StrategyPattern.Solution
{
    internal class PngCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing png file"); ;
        }
    }
}
