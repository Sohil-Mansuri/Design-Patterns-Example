
namespace AbstractFactoryPattern.Solution.Ant
{
    internal class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant : Button");
        }
    }
}
