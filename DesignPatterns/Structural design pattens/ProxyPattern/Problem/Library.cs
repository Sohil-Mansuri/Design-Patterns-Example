
namespace ProxyPattern.Problem
{
    internal class Library
    {
        public Dictionary<string, Ebook> Ebooks { get; set; } = [];

        public void View(string fileName)
        {
            if (Ebooks.TryGetValue(fileName, out Ebook? ebook))
            {
                ebook.Show();
            }
        }
    }
}
