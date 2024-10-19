
namespace VisitorDesignPattern.Problem
{
    internal class HtmlDocument
    {
        public List<IHtmlNode> Nodes { get; set; } = [];

        public void HighLight()
        {
            foreach (var node in Nodes)
            {
                node.Highligh();
            }
        }

        public void Bold()
        {
            foreach(var node in Nodes)
            {
                node.Bold();
            }
        }
    }
}
