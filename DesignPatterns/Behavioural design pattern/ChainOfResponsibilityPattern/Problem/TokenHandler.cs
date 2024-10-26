
namespace ChainOfResponsibilityPattern.Problem
{
    internal class TokenHandler : ITokenHandler
    {
        public void CreateToken()
        {
            Console.WriteLine("Token generated", new Random().Next());
        }
    }
}
