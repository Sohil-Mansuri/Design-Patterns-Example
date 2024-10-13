
namespace CommandPattern.Example3
{
    internal class ReSizeCommand(HtmlDocument document, History history) : IUnDoableCommand
    {
        private int _preSize;
        public void Execute()
        {
            _preSize = document.Size;
            document.ReSize();
            history.Push(this);
        }

        public void UnExecute()
        {
            document.Size = _preSize;
        }
    }
}
