

namespace MementoPattern.Solution
{
    /// <summary>
    /// Caretaker
    /// </summary>
    public class History
    {
        private Stack<EditorState> _history = new();


        public void Push(EditorState state)
        {
            _history.Push(state);
        }

        public EditorState? Pop()
        {
            _history.Pop();
            if(_history.Count > 0)
            {
                return _history.Peek();
            }

            return null;
            
        }
    }
}
