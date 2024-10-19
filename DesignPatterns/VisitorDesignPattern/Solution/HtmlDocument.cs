
namespace VisitorDesignPattern.Solution
{
    internal class HtmlDocument
    {
        public List<IHtmlNode> Nodes { get; set; } = [];

        public void Apply(IOperation operation)
        {
            foreach (var node in Nodes)
            {
               node.Execute(operation);
            }
        }

    }
}
