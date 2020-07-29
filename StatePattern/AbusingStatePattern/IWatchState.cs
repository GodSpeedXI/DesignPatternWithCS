namespace DesignPatternPractice.StatePattern.AbusingStatePattern
{
    public interface IWatchState
    {
        void ChangeState();
        string GetStateName();
    }
}
