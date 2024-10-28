
namespace BuilderPattern
{
    /// <summary>
    /// Representation
    /// </summary>
    internal class Movie
    {
        private List<string> _frames = [];
        public void AddFrames(Slide slide) => _frames.Add(slide.Text + " From Movie");

        public void GetMovie()
        {
            foreach (var frame in _frames)
            {
                Console.WriteLine(frame);
            }
        }
    }
}
