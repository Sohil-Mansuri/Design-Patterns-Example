

namespace StrategyPattern.Solution
{
    internal class HighContrastFilter : IFilter
    {
        public void ApplyFilter()
        {
            Console.WriteLine("Applying High contrast filter");
        }
    }
}
