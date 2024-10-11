

namespace MementoPattern.Solution
{
    /// <summary>
    /// Orginator
    /// </summary>
    public class Editor
    {
        private string _content = string.Empty;

        public EditorState CreateEditorState()
        {
            return new EditorState(_content);
        }

        public void RestoreState(EditorState? state)
        {
            if (state is not null)
            {
                _content = state.GetContent();
            }
        }

        public void AddContent(string content)
        {
            if (_content is not null)
            {
                _content = content;
            }
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
