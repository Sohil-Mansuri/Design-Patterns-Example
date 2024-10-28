
namespace BuilderPattern.Problem
{
    /// <summary>
    /// Presentation 
    /// here its not follwing OCP
    /// also its duplicate code for each type of export
    /// </summary>
    internal class Presentation
    {
        private List<Slide> _slides = [];

        public void AddSlide(string text) => _slides.Add(new Slide { Text = text });


        /// <summary>
        /// Construction logic 
        /// </summary>
        /// <param name="format"></param>
        public void Export(PresentationFormat format)
        {
            if(format == PresentationFormat.PDF)
            {
                var pdfDocument = new PDFDocument();
                foreach (var slide in _slides)
                    pdfDocument.AddPages(slide);

                pdfDocument.GetPdfDocument();
            }
            else if (format == PresentationFormat.Movie)
            {
                var movie = new Movie();
                foreach (var slide in _slides)
                    movie.AddFrames(slide);

                movie.GetMovie();
            }
        }
    }
}
