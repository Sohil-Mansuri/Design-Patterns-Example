
namespace StrategyPattern.Solution
{
    internal class JpgCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing jpg image");
        }
    }
}
