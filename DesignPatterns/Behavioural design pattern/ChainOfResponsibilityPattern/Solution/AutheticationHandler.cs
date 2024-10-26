
namespace ChainOfResponsibilityPattern.Solution
{
    internal class AutheticationHandler(Handler handler) : Handler(handler)
    {
        protected override bool DoHandle(HttpRequest httpRequest)
        {
            if (httpRequest == null)
            {
                Console.WriteLine("Request is null");
                return false;
            }

            return httpRequest.Username == "admin" && httpRequest.Password == "admin";
        }
    }
}
