
namespace VisitorDesignPattern.Problem
{
    internal class HeadingNode : IHtmlNode
    {
        public void Bold()
        {
            Console.WriteLine("Heading tag text bold");
        }

        public void Highligh()
        {
            Console.WriteLine("Heading tag highlighted");
        }
    }
}
