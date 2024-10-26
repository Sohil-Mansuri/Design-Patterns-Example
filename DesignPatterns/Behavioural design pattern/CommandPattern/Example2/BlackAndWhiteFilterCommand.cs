
namespace CommandPattern.Example2
{
    internal class BlackAndWhiteFilterCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and white filter applied");
        }
    }
}
