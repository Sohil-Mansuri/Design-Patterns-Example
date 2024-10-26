

namespace StatePattern.Over_use_of_State_pattern.Complex
{
    /// <summary>
    /// This is very compelx solution
    /// </summary>
    internal class Stopwatch
    {
        private IStopwatchOperations _currentState;

        public Stopwatch()
        {
            _currentState = new StopState(this);
        }
        public void Click()
        {
            _currentState.Click();
        }


        public void SetCurrentState(IStopwatchOperations currentState)
        {
            _currentState = currentState;
        }
    }
}
