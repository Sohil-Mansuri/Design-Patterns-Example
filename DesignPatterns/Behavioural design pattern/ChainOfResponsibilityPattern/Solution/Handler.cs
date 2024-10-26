

namespace ChainOfResponsibilityPattern.Solution
{
    internal abstract class Handler(Handler? next)
    {
        /// <summary>
        /// This our template 
        /// we will call this from client
        /// </summary>
        public void Handle(HttpRequest httpRequest)
        {
            if (DoHandle(httpRequest))
                next?.Handle(httpRequest);

            //if request is not handled then return 
        }

        /// <summary>
        /// its implementation vary from handler to handler
        /// </summary>
        /// <returns></returns>
        protected abstract bool DoHandle(HttpRequest httpRequest);
    }
}
