

namespace CommandPattern.Example2
{
    /// <summary>
    /// This will run all the command in sequence
    /// </summary>
    internal class CompositeCommand() : ICommand
    {
        private List<ICommand> _commands = [];
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }
    }
}
