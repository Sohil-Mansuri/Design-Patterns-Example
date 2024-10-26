

namespace StatePattern.Solution
{
    /// <summary>
    /// Concreate classes 
    /// </summary>
    internal class SelectionTool : IToolOperations
    {
        public void MouseDown()
        {
            Console.WriteLine("draw a rectangle");
        }

        public void MouseUp()
        {
            Console.WriteLine("selectin icon");
        }
    }
}
