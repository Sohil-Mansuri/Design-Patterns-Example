namespace FactoryMethodPattern.Example
{
    internal class SharpViewEngine : IViewEngine
    {
        public void Render()
        {
            Console.WriteLine("Rendered by Sharpview engine");
        }
    }
}
