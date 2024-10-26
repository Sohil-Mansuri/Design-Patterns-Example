
namespace ChainOfResponsibilityPattern.Problem
{
    internal class RequestHandler : IRequestHandler
    {
        public void HandleRequest()
        {
            Console.WriteLine("Request handled");
        }
    }
}
