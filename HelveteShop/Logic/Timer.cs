using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ClientLogic
{
    public class Timer
    {
        public event Action OnTimerReach;

        public Timer(float time)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = time;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            OnTimerReach?.Invoke();
        }
    }
}
