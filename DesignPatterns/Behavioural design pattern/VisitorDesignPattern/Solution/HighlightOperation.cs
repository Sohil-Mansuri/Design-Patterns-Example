

namespace VisitorDesignPattern.Solution
{
    internal class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("highlight heading");
        }

        public void Apply(AncharNode node)
        {
            Console.WriteLine("highlight anchor");
        }
    }
}
