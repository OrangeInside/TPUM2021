using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic
{
    public interface ISrvTimeTracker
    {
        public Task StartTimer();
        public void StopTimer();
    }
}
