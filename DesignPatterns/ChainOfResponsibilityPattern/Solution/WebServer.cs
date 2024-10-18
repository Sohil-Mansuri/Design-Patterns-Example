
namespace ChainOfResponsibilityPattern.Solution
{
    /// <summary>
    /// Client
    /// </summary>
    internal class WebServer(Handler handler)
    {
        public void HandleHttpRequest(HttpRequest httpRequest)
        {
            handler.Handle(httpRequest);
        }
    }
}
