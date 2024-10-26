

namespace StatePattern.Solution
{
    /// <summary>
    /// Concreate classes 
    /// </summary>
    internal class BrushTool : IToolOperations
    {
        public void MouseDown()
        {
            Console.WriteLine("Erase something");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase icon");
        }
    }
}
