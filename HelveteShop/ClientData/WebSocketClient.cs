using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ClientData
{
    public static class WebSocketClient
    {
        public static async Task<WebSocketConnection> Connect(Uri peer, Action<string> log)
        {
            ClientWebSocket clientWebSocket = new ClientWebSocket();
            await clientWebSocket.ConnectAsync(peer, CancellationToken.None);

            switch (clientWebSocket.State)
            {
                case WebSocketState.Open:
                    log?.Invoke($"Opened connection to remote server: {peer}");
                    WebSocketConnection socketConnection = new ClientWebSocketConnection(clientWebSocket, peer, log);
                    return socketConnection;

                default:
                    string errorMessage = $"Cannot connect to remote server {peer} with status {clientWebSocket.State}";
                    log?.Invoke(errorMessage);
                    throw new WebSocketException(errorMessage);
            }
        }

        public class ClientWebSocketConnection : WebSocketConnection
        {
            private ClientWebSocket clientWebSocket = null;
            private Uri peer = null;
            private readonly Action<string> log;

            public ClientWebSocketConnection(ClientWebSocket clientWebSocket, Uri peer, Action<string> log)
            {
                this.log = log;
                this.peer = peer;
                this.clientWebSocket = clientWebSocket;
                Task.Factory.StartNew(() => ClientMessageLoop());
            }
            protected override Task SendTask(string message)
            {
                throw new NotImplementedException();
            }

            public override Task AsyncDisconnect()
            {
                throw new NotImplementedException();
            }


            private void ClientMessageLoop()
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    while (true)
                    {
                        ArraySegment<byte> segment = new ArraySegment<byte>(buffer);
                        WebSocketReceiveResult result = clientWebSocket.ReceiveAsync(segment, CancellationToken.None).Result;
                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            onClose?.Invoke();
                            clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "I am closing", CancellationToken.None).Wait();
                            return;
                        }
                        int count = result.Count;
                        while (!result.EndOfMessage)
                        {
                            if (count >= buffer.Length)
                            {
                                onClose?.Invoke();
                                clientWebSocket.CloseAsync(WebSocketCloseStatus.InvalidPayloadData, "That's too long", CancellationToken.None).Wait();
                                return;
                            }
                            segment = new ArraySegment<byte>(buffer, count, buffer.Length - count);
                            result = clientWebSocket.ReceiveAsync(segment, CancellationToken.None).Result;
                            count += result.Count;
                        }
                        string message = Encoding.UTF8.GetString(buffer, 0, count);
                        onMessage?.Invoke(message);
                    }
                }
                catch (Exception _ex)
                {
                    log($"Connection has been broken because of an exception {_ex}");
                    clientWebSocket.CloseAsync(WebSocketCloseStatus.InternalServerError, "Connection has been broken because of an exception", CancellationToken.None).Wait();
                }
            }
        }
    }
}
