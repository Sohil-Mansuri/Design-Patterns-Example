

using StatePattern.Over_use_of_State_pattern.Complex;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem Section Output");

            var canvas = new Problem.Canvas(Problem.ToolType.Eraser);
            canvas.MouseUp();
            canvas.MouseDown();

            Console.WriteLine("Solution Section Output");

            var newCanvas = new Solution.Canvas(new Solution.BrushTool());
            newCanvas.MouseUp();
            newCanvas.MouseDown();

            //lets change state
            Console.WriteLine("State is changed");
            newCanvas.ChangeTool(new Solution.SelectionTool());
            newCanvas.MouseUp();
            newCanvas.MouseDown();


            //Abusing section 
            Console.WriteLine("Abusing State pattern example");
            Console.WriteLine("Output from best soutio");

            var stopwatch = new Over_use_of_State_pattern.BestSolution.Stopwatch();
            stopwatch.Click();
            stopwatch.Click();

            Console.WriteLine("Output from very complex solution");

            var newStopwatch = new Stopwatch();
            newStopwatch.Click();
            newStopwatch.Click();

            Console.ReadKey();
        }
    }
}
