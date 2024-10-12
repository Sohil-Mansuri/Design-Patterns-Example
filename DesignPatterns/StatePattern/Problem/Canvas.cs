

namespace StatePattern.Problem
{
    public class Canvas(ToolType toolType)
    {
        public void MouseUp()
        {
            if (toolType == ToolType.Selection)
                Console.WriteLine("Selection icon");
            else if (toolType == ToolType.Brush)
                Console.WriteLine("Brush icon");
            else if(toolType == ToolType.Eraser)
                Console.WriteLine("Eraser icon");
        }

        public void MouseDown()
        {
            if (toolType == ToolType.Selection)
                Console.WriteLine("draw rectangel");
            else if (toolType == ToolType.Brush)
                Console.WriteLine("fill it");
            else if (toolType == ToolType.Eraser)
                Console.WriteLine("Eraser something");
        }
    }


    public enum ToolType
    {
        Selection,
        Brush,
        Eraser
    }
}
