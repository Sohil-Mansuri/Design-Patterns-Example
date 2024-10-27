
namespace ProxyPattern.Problem
{
    internal class Ebook
    {
        public Ebook(string title)
        {
            Title = title;
            Load();
        }
        public string Title { get; init; }

        public void Load()
        {
            Console.WriteLine("Loading___ {0}", Title);
        }


        public void Show()
        {
            Console.WriteLine("Showing {0}", Title);
        }


    }
}
