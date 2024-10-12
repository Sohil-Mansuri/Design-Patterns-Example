
namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from Problem section");

            var history = new Problem.BrowserHistory();
            history.Push("sohil.com");
            history.Push("websmith.com");
            history.Push("musafir.com");

            var urls = history.GetUrls();
            for (int i = 0; i < urls.Count; i++)
            {
                Console.WriteLine(urls[i]);
            }


            Console.WriteLine("Output from Solution section");

            var newHistory = new Solution.BrowserHistory();
            newHistory.Push("sohil.com");
            newHistory.Push("websmith.com");
            newHistory.Push("musafir.com");

            var iterator = newHistory.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.CurrectValue());
                iterator.Next();
            }

            Console.ReadKey();
        }
    }
}
