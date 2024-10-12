

namespace StatePattern.Over_use_of_State_pattern.Complex
{
    internal class RunningState(Stopwatch stopwatch) : IStopwatchOperations
    {
        public void Click()
        {
            stopwatch.SetCurrentState(new StopState(stopwatch));
            Console.WriteLine("Stopped");
        }
    }
}
