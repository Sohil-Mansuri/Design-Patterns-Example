
namespace ProxyPattern.Solution
{
    internal class LoggingEbookProxy(string title) : IEbook
    {
        private RealEbook _realEbook;
        public string GetFileName()
        {
            return title;
        }

        //Adding more functionality of the main object 
        public void Show()
        {
            Console.WriteLine("Request came for this file {0}", title);
            _realEbook ??= new RealEbook(title);

            _realEbook.Show();

        }
    }
}
