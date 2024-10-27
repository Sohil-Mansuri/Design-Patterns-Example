
namespace DecoratorPattern.Solution
{
    internal class CloudStreamComponent : IComponent
    {
        public void Operation(string data)
        {
            Console.WriteLine("output : {0}", data);
        }
    }
}
