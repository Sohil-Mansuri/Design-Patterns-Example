
namespace BuilderPattern.Solution
{
    internal class PDFBuilder : IPresentaionBuilder
    {
        PDFDocument _document = new();
        public void AddData(Slide slide)
        {
            _document.AddPages(slide);
        }


        public void GetDocument()
        {
            _document.GetPdfDocument();
        }
    }
}
