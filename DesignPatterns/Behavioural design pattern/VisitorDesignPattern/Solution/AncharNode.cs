
namespace VisitorDesignPattern.Solution
{
    internal class AncharNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
