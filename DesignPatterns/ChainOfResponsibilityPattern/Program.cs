
namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Problem selection");

            Problem.IAuthetication authetication = new Problem.Authentication();
            Problem.ILogger logger = new Problem.Logger();
            Problem.ITokenHandler tokenHandler = new Problem.TokenHandler();
            Problem.IRequestHandler requestHandler = new Problem.RequestHandler();
            var webServer = new Problem.WebServer(authetication, logger, tokenHandler, requestHandler);
            var httpRequest = new Problem.HttpRequest
            {
                Username = "admin",
                Password = "admin",
            };

            webServer.Handle(httpRequest);

            Console.WriteLine("Output from Solution selection");

            //we want to setup this chain Authentication -> Logger -> Compression
            
            Solution.CompressionHandler compressionHandler = new(null);
            Solution.LoggerHandler loggerHandler = new(compressionHandler);
            Solution.AutheticationHandler autheticationHandler = new(loggerHandler);

            Solution.WebServer newWebServer = new(autheticationHandler);
            Solution.HttpRequest request = new()
            {
                Username = "admin",
                Password = "admin",
            };

            newWebServer.HandleHttpRequest(request);

            //now if you want to remove or Add new middleware then you don't need to update implementation 

            Console.ReadKey();
        }
    }
}
