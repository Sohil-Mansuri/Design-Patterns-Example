
namespace CommandPattern.Example1
{
    /// <summary>
    /// Invoker
    /// </summary>
    /// <param name="command"></param>
    internal class Button(ICommand command)
    {
        public void Click()
        {
            command.Execute();
        }
    }
}
