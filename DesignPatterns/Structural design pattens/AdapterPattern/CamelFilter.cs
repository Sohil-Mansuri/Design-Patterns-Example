
namespace AdapterPattern
{
    /// <summary>
    /// Adapter
    /// </summary>
    internal class CamelFilter : IFilter
    {
        private readonly CamelThirdParyFilter _camelThirdParyFilter;

        public CamelFilter(CamelThirdParyFilter camelThirdParyFilter)
        {
            _camelThirdParyFilter = camelThirdParyFilter;
        }
        public void Apply(Image image)
        {
            _camelThirdParyFilter.Init();
            _camelThirdParyFilter.Process(image);
        }
    }
}
