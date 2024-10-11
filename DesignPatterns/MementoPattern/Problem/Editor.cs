
namespace MementoPattern.Problem
{
    /// <summary>
    /// It is implementing Undo feature but it is not the optimal solution or best solution 
    /// Suppore tomorrow we get new text filed as Title then again you have to 
    /// add new Stack to maintain its values 
    /// also again you have to do changes in existing implementation 
    /// so Its violating OCP principle (Open-Closed principle)
    /// </summary>
    public class Editor
    {
        private string? _content;
        private Stack<string> _contentPreviousData = new();

        public void Add(string content)
        {
            if (content is not null)
            {
                _contentPreviousData.Push(content);
                _content = content;
            }
        }

        public string? Get()
        {
            return _content;
        }

        public void Undo()
        {
            if (_contentPreviousData.Count > 0)
            {
                _contentPreviousData.Pop();
                _content = _contentPreviousData.Peek();
            }
        }
    }
}
