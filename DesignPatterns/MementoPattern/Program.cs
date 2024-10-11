

namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // From Probelm Section : 
            Console.WriteLine("From Problem Section ");
            var editor = new Problem.Editor();
            editor.Add("a");
            editor.Add("b");
            editor.Add("c");
            editor.Add("d");
            editor.Add("e");
            editor.Add("f");

            editor.Undo();
            editor.Undo();
            editor.Undo();

            var previousValue = editor.Get();

            Console.WriteLine("old value is {0}", previousValue);

            //From Solution Section 
            Console.WriteLine("From Solution Section ");

            var sEditor = new Solution.Editor();
            var history = new Solution.History();

            sEditor.AddContent("a");
            history.Push(sEditor.CreateEditorState());

            sEditor.AddContent("b");
            history.Push(sEditor.CreateEditorState());

            sEditor.AddContent("c");
            history.Push(sEditor.CreateEditorState());

            sEditor.RestoreState(history.Pop());

            var preV = sEditor.GetContent();

            Console.WriteLine("prev value is {0}", preV);


        }
    }
}
