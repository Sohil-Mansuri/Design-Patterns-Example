
namespace DecoratorPattern.Solution
{
    internal class CompressComponenet(IComponent component) : IComponent
    {
        public void Operation(string data)
        {
            var compressData = data.Substring(0, 4);
            Console.WriteLine("Compress data {0}", compressData);
            component.Operation(compressData);
        }
    }
}
