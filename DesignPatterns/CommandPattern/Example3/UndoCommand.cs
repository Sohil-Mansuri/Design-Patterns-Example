
namespace CommandPattern.Example3
{
    internal class UndoCommand(History history) : ICommand
    {
        public void Execute()
        {
            if (history.Size() > 0)
                history.Pop().UnExecute();
        }
    }
}
