using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ClientData;

namespace ClientLogic
{
    public class SrvTimeTracker : ISrvTimeTracker
    {
        private readonly ITimeTracker timeTracker;

        public SrvTimeTracker()
        {
            timeTracker = TimeTracker.Instance;
        }

        public async Task StartTimer()
        {
            await timeTracker.Start();
        }

        public void StopTimer()
        {
            timeTracker.Stop();
        }
    }
}
