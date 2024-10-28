namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output from problem section");

            var presentation = new Problem.Presentation();
            presentation.AddSlide("Slide 1");
            presentation.AddSlide("Slide 2");

            presentation.Export(PresentationFormat.PDF);

            Console.WriteLine("Output from Solution section");

            var newPresentation = new Solution.Presentation();
            newPresentation.AddSlide("Slide 1");
            newPresentation.AddSlide("Slide 2");
            var builder = new Solution.PDFBuilder();
            newPresentation.Export(builder);

            builder.GetDocument();
        }
    }
}
