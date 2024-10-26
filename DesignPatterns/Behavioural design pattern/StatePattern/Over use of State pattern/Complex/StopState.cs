

namespace StatePattern.Over_use_of_State_pattern.Complex
{
    /// <summary>
    /// This is very complex code
    /// </summary>
    /// <param name="stopwatch"></param>
    internal class StopState(Stopwatch stopwatch) : IStopwatchOperations
    {
        public void Click()
        {
            stopwatch.SetCurrentState(new RunningState(stopwatch));
            Console.WriteLine("Running");
        }
    }
}
