
namespace CommandPattern.Example2
{
    internal class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resized");
        }
    }
}
