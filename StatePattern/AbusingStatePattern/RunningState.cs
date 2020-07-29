using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.StatePattern.AbusingStatePattern
{
    public class RunningState : IWatchState
    {
        private StopWatch _stopWatch;

        public RunningState(StopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
        public void ChangeState()
        {
            _stopWatch.SetCurrentState(new StopState(_stopWatch));
        }

        public string GetStateName()
        {
            return "Running";
        }
    }
}
