
namespace BuilderPattern
{
    /// <summary>
    /// Representation
    /// </summary>
    internal class PDFDocument
    {
        private List<string> _pages = [];

        public void AddPages(Slide slide) => _pages.Add(slide.Text + " From PDF");

        public void GetPdfDocument()
        {
            foreach (var page in _pages)
            {
                Console.WriteLine(page);
            }
        }
    }
}
