using System;
using System.Threading.Tasks;

namespace ServerPresentation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Action<string> consoleLog = Console.WriteLine;

            await WebSocketServer.Server(8081, ConnectionHandler);
        }

        static void ConnectionHandler(WebSocketConnection webSocketConnection)
        {
            webSocketConnection.onMessage = Console.WriteLine;
            webSocketConnection.onClose = () => { Console.WriteLine("Connection closed"); };
            webSocketConnection.onError = () => { Console.WriteLine("Connection error encountered"); };
        }
    }
}
