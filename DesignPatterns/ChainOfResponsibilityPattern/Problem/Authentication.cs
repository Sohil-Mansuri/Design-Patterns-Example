
namespace ChainOfResponsibilityPattern.Problem
{
    internal class Authentication : IAuthetication
    {
        public bool Autheticate(HttpRequest httpRequest)
        {
            return (httpRequest.Username == "admin"&& httpRequest.Password == "admin");
        }
    }
}
