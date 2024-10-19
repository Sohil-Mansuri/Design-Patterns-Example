
namespace VisitorDesignPattern.Solution
{
    internal class HtmlDocument(IOperation operation)
    {
        public List<IHtmlNode> Nodes { get; set; } = [];

        public void Apply()
        {
            foreach (var node in Nodes)
            {
               node.Execute(operation);
            }
        }

    }
}
