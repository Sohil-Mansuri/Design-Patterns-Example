
namespace BuilderPattern.Solution
{
    internal class Presentation
    {
        private List<Slide> _slides = [];

        public void AddSlide(string text) => _slides.Add(new Slide { Text = text });


        /// <summary>
        /// Construction logic is seperated
        /// now using this same construction logic we can 
        /// implement different type of objects
        /// </summary>
        /// <param name="presentaionBuilder"></param>
        public void Export(IPresentaionBuilder presentaionBuilder)
        {
            foreach (var slide in _slides)
            {
                presentaionBuilder.AddData(slide);
            }
        }
    }
}
