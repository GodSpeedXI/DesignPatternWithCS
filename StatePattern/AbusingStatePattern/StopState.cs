using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.StatePattern.AbusingStatePattern
{
    public class StopState : IWatchState
    {
        private StopWatch _stopWatch;

        public StopState(StopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
        public void ChangeState()
        {
            _stopWatch.SetCurrentState(new RunningState(_stopWatch));
        }

        public string GetStateName()
        {
            return "Stopped";
        }
    }
}
