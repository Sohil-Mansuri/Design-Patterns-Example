
namespace StatePattern.Over_use_of_State_pattern.BestSolution
{
    /// <summary>
    /// This is best solution, here no scope of getting new state
    /// </summary>
    internal class Stopwatch
    {
        private bool _isRunning;
        public void Click()
        {
            if (_isRunning)
            {
                Console.WriteLine("Stopped");
                _isRunning = false;
            }
            else
            {
                Console.WriteLine("Running");
                _isRunning = true;
            }
        }
    }
}
