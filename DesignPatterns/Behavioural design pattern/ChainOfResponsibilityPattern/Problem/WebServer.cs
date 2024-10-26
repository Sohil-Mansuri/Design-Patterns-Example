

namespace ChainOfResponsibilityPattern.Problem
{
    /// <summary>
    /// This is not the correct way as if no of middleware increase then 
    /// again we have to update this code, not follwing OCP
    /// also here order is fixed but at runtime we have to change the order then again
    /// we have to update existing code
    /// </summary>
    /// <param name="authetication"></param>
    /// <param name="logger"></param>
    /// <param name="tokenHandler"></param>
    /// <param name="requestHandler"></param>
    internal class WebServer(IAuthetication authetication, ILogger logger, ITokenHandler tokenHandler, IRequestHandler requestHandler)
    {
        
        public void Handle(HttpRequest httpRequest)
        {
            // lets define our pipline 

            var isAutheticated = authetication.Autheticate(httpRequest);
            if (isAutheticated)
            {
                logger.Log($"{httpRequest.Username} is autheticated");

                //generated token
                tokenHandler.CreateToken();

                //handle request
                requestHandler.HandleRequest();
            }
            else
            {
                Console.WriteLine("Authetication failed");
            }
        }
    }
}
