

namespace StatePattern.Solution
{
    /// <summary>
    /// Context
    /// </summary>
    /// <param name="tool"></param>
    internal class Canvas(IToolOperations tool)
    {
        public void MouseUp()
        {
            tool.MouseUp();
        }


        public void MouseDown()
        {
            tool.MouseDown();
        }

        public void ChangeTool(IToolOperations toolOperations)
        {
            tool = toolOperations;
        }
    }
}
