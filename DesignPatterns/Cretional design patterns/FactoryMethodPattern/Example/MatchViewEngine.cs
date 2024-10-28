namespace FactoryMethodPattern.Example
{
    internal class MatchViewEngine : IViewEngine
    {
        public void Render()
        {
            Console.WriteLine("Rendere by MatchView engine");
        }
    }
}
