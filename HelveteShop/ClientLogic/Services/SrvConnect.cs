using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ClientData;
using System.Diagnostics;
using System.Drawing;
using System.Net.WebSockets;

namespace ClientLogic.Services
{
    public class SrvConnect
    {
        public bool IsConnected => clientSocketConnection != null;

        public Action<string> connectLogger;
        public WebSocketConnection clientSocketConnection;

        public async Task<bool> Connect(Uri peerUri, Action<string> logger)
        {
            try
            {
                connectLogger = logger;
                connectLogger?.Invoke($"Establishing connection to {peerUri.OriginalString}");

                clientSocketConnection = await WebSocketClient.Connect(peerUri, connectLogger);

                return true;
            }
            catch (WebSocketException e)
            {
                Debug.WriteLine($"Caught web socket exception {e.Message}");
                connectLogger?.Invoke(e.Message);
                return false;
            }
        }
    }
}
