
namespace CommandPattern.Example3
{
    internal class BoldCommand(HtmlDocument document, History history) : IUnDoableCommand
    {
        private string? _prev;
        public void Execute()
        {
            _prev = document.Content;
            //delegating work
            document.makeBold();
            history.Push(this);
        }

        public void UnExecute()
        {
            document.Content = _prev;
        }
    }
}
