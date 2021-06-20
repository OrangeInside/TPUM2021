using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientData
{
    public class TimeTracker : ITimeTracker
    {
        private static TimeTracker instance;
        public static TimeTracker Instance
        {
            get 
            { 
                return instance ??= new TimeTracker(); 
            }
            private set => instance = value;
        }

        private bool isProcessingTime;
        private float currentTime = 0.0f;

        public async Task Start()
        {
            isProcessingTime = true;

            while (isProcessingTime)
            {
                await WebSocketClient.CurrentConnection.SendAsync(MessageParser.Create("TimeInterval", 1.0f, 1.0f.GetType().Name));

                System.Threading.Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            isProcessingTime = false;
        }
    }
}
