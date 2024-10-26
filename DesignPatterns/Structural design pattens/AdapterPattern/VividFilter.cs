
namespace AdapterPattern
{
    internal class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid filter");
        }
    }
}
