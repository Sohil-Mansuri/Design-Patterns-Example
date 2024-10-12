

namespace StrategyPattern.Solution
{
    internal class BlackAndWhiteFilter : IFilter
    {
        public void ApplyFilter()
        {
            Console.WriteLine("Applying black and white filter");
        }
    }
}
