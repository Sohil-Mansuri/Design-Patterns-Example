
namespace CommandPattern.Example3
{
    /// <summary>
    /// why seprate interface, because all command are not
    /// undoable
    /// </summary>
    internal interface IUnDoableCommand : ICommand
    {
        /// <summary>
        /// Reset what ever set by Execute
        /// </summary>
        void UnExecute();
    }
}
