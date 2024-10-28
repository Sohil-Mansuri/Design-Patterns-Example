
namespace BuilderPattern.Solution
{
    internal class MovieBuilder : IPresentaionBuilder
    {
        private Movie _movie = new();

        public void AddData(Slide slide)
        {
            _movie.AddFrames(slide);
        }

        public void GetMovie()
        {
            _movie.GetMovie();
        }
    }
}
