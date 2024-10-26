
namespace ChainOfResponsibilityPattern.Solution
{
    internal class LoggerHandler(Handler next) : Handler(next)
    {
        protected override bool DoHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("{0} is logged in", httpRequest.Username);
            return true;
        }
    }
}
