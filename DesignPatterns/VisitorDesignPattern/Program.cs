
namespace VisitorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from probelm section");

            var htmlDocument = new Problem.HtmlDocument();
            htmlDocument.Nodes.Add(new Problem.HeadingNode());
            htmlDocument.Nodes.Add(new Problem.AnchorNode());

            htmlDocument.HighLight();
            htmlDocument.Bold();

            Console.WriteLine("Output from Solution section");

            var newHtmlDocument = new Solution.HtmlDocument();
            newHtmlDocument.Nodes.Add(new Solution.HeadingNode());
            newHtmlDocument.Nodes.Add(new Solution.AncharNode());

            newHtmlDocument.Apply(new Solution.PlainTextOperation());

            Console.ReadKey();
        }
    }
}
