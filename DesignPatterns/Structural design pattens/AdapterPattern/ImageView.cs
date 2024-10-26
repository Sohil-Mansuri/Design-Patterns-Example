

namespace AdapterPattern
{
    internal class ImageView
    {
        public void AppyFilter(IFilter filter, Image image)
        {
            filter.Apply(image);
        }
    }
}
