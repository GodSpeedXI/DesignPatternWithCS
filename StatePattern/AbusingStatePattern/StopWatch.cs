namespace DesignPatternPractice.StatePattern.AbusingStatePattern
{
    /// <summary>
    /// This is an example of Abusing State Pattern.
    /// Do not use this practice because it's overly engineer.
    /// and too complicated.
    /// </summary>
    public class StopWatch
    {
        private IWatchState _currentState;

        public StopWatch()
        {
            _currentState = new StopState(this);
        }
        public void SetCurrentState(IWatchState state)
        {
            _currentState = state;
        }

        public string GetCurrentState()
        {
            return _currentState.GetStateName();
        }
    }
}
