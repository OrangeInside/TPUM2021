using System;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerPresentation
{
    public static class WebSocketServer
    {
        public static async Task Server(int p2p_port, Action<WebSocketConnection> onConnection)
        {
            Uri uri = new Uri($@"http://localhost:{p2p_port}/");
            await ServerLoop(uri, onConnection);
        }

        private static async Task ServerLoop(Uri uri, Action<WebSocketConnection> onConnection)
        {
            HttpListener server = new HttpListener();
            server.Prefixes.Add(uri.ToString());
            server.Start();

            while (true)
            {
                HttpListenerContext httpContext = await server.GetContextAsync();

                if (!httpContext.Request.IsWebSocketRequest)
                {
                    httpContext.Response.StatusCode = 400;
                    httpContext.Response.Close();
                }

                HttpListenerWebSocketContext _context = await httpContext.AcceptWebSocketAsync(null);
                WebSocketConnection ws = new ServerWebSocketConnection(_context.WebSocket, httpContext.Request.RemoteEndPoint);
                onConnection?.Invoke(ws);
            }
        }

        private class ServerWebSocketConnection : WebSocketConnection
        {
            public ServerWebSocketConnection(WebSocket webSocket, IPEndPoint remoteEndPoint)
            {
                this.webSocket = webSocket;
                this.remoteEndPoint = remoteEndPoint;
                Task.Factory.StartNew(() => ServerMessageLoop(webSocket));
            }

            protected override Task SendTask(string message)
            {
                return webSocket.SendAsync(message.GetArraySegment(), WebSocketMessageType.Text, true, CancellationToken.None);
            }

            public override Task Disconnect()
            {
                return webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing started", CancellationToken.None);
            }

            public override string ToString()
            {
                return remoteEndPoint.ToString();
            }

            private WebSocket webSocket = null;
            private IPEndPoint remoteEndPoint;

            private void ServerMessageLoop(WebSocket ws)
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    ArraySegment<byte> segments = new ArraySegment<byte>(buffer);
                    WebSocketReceiveResult _receiveResult = ws.ReceiveAsync(segments, CancellationToken.None).Result;
                    
                    if (_receiveResult.MessageType == WebSocketMessageType.Close)
                    {
                        onClose?.Invoke();
                        ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "I am closing", CancellationToken.None);
                        return;
                    }

                    int count = _receiveResult.Count;
                    while (!_receiveResult.EndOfMessage)
                    {
                        if (count >= buffer.Length)
                        {
                            onClose?.Invoke();
                            ws.CloseAsync(WebSocketCloseStatus.InvalidPayloadData, "That's too long", CancellationToken.None);
                            return;
                        }
                        segments = new ArraySegment<byte>(buffer, count, buffer.Length - count);
                        _receiveResult = ws.ReceiveAsync(segments, CancellationToken.None).Result;
                        count += _receiveResult.Count;
                    }

                    string _message = Encoding.UTF8.GetString(buffer, 0, count);
                    onMessage?.Invoke(_message);
                }
            }
        }

        internal static ArraySegment<byte> GetArraySegment(this string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            return new ArraySegment<byte>(buffer);
        }
    }
}