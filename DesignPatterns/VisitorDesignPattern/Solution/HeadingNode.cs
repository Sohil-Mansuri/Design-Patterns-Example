
namespace VisitorDesignPattern.Solution
{
    internal class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
