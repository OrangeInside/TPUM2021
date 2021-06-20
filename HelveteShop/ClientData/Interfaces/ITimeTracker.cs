using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientData
{
    public interface ITimeTracker
    {
        public Task Start();
        public void Stop();
    }
}
