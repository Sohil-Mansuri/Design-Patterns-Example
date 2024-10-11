

namespace MementoPattern.Solution
{
    /// <summary>
    /// Memento
    /// </summary>
    /// <param name="content"></param>
    public class EditorState(string content)
    {
        public string GetContent()
        {
            return content;
        }
    }
}
