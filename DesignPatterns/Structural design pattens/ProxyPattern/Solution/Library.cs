
using ProxyPattern.Problem;

namespace ProxyPattern.Solution
{
    internal class Library
    {
        public Dictionary<string, IEbook> Ebooks { get; set; } = [];

        public void View(string fileName)
        {
            if (Ebooks.TryGetValue(fileName, out IEbook ebook))
            {
                ebook.Show();
            }
        }
    }
}
