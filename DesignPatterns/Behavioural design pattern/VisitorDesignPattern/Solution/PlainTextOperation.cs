
namespace VisitorDesignPattern.Solution
{
    internal class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Heading node plain text");
        }

        public void Apply(AncharNode node)
        {
            Console.WriteLine("Anchor tag plain text");
        }
    }
}
