
namespace ChainOfResponsibilityPattern.Solution
{
    internal class CompressionHandler(Handler? next) : Handler(next)
    {
        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compression is handled");
            return true;
        }
    }
}
