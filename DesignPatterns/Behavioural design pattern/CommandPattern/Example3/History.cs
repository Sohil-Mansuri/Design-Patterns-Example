
namespace CommandPattern.Example3
{
    internal class History
    {
        private Stack<IUnDoableCommand> _history = [];

        public void Push(IUnDoableCommand command)
        {
            _history.Push(command);
        }

        public IUnDoableCommand Pop()
        {
            var command = _history.Pop();
            return command;
        }

        public int Size()
        {
            return _history.Count;
        }
    }
}
