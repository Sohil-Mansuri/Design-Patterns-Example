namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from problem section");

            var library = new Problem.Library();
            string[] books = ["Gang of four", "Game of thrones", "Stranger things"];
            
            foreach (string book in books)
            {
                library.Ebooks.Add(book, new Problem.Ebook(book));
            }

            library.View("Stranger things");

            //its loading all the books althoug its viewing only Stranger things book 


            Console.WriteLine("Output from Solution section");

            var newLibrary = new Solution.Library();

            foreach (string book in books)
            {
                newLibrary.Ebooks.Add(book, new Solution.EbookProxy(book));
            }

            newLibrary.View("Stranger things");

            Console.WriteLine("Logging Ebook Prxy example");

            //we can add new funcationality of exsting object without updating exiting code
            //follwing OCP as you can we we are able to do loggin also 

            var newLibrary2 = new Solution.Library();

            foreach (string book in books)
            {
                newLibrary2.Ebooks.Add(book, new Solution.LoggingEbookProxy(book));
            }

            newLibrary2.View("Game of thrones");

            Console.ReadKey();
        }
    }
}
