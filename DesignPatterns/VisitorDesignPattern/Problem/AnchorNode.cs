
namespace VisitorDesignPattern.Problem
{
    internal class AnchorNode : IHtmlNode
    {
        public void Bold()
        {
            Console.WriteLine("Anchor tag text bold");
        }

        public void Highligh()
        {
            Console.WriteLine("Anchor tag highlighted");
        }
    }
}
