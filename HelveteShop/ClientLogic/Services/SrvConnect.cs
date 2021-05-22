using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientLogic.Services
{
    public class SrvConnect
    {
        public bool IsConnected { get; set; }

        public async Task<bool> Connect(Uri peerUri)
        {
            // TODO: implementation
            IsConnected = peerUri.OriginalString != "";
            return IsConnected;
        }
    }
}
