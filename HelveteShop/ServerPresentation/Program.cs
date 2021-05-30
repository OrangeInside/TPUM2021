using System;
using System.Globalization;
using System.Threading.Tasks;
using ServerLogic;

namespace ServerPresentation
{
    class Program
    {
        private static WebSocketConnection CurrentConnection;
        private static readonly IVinylServices srvVinyls = new SrvVinyls();

        static async Task Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Action<string> consoleLog = Console.WriteLine;

            await WebSocketServer.Server(8081, ConnectionHandler);
        }

        static void ConnectionHandler(WebSocketConnection webSocketConnection)
        {
            CurrentConnection = webSocketConnection;
            webSocketConnection.onMessage = ParseMessage;
            webSocketConnection.onClose = () => { Console.WriteLine("[From Server]: Connection closed"); };
            webSocketConnection.onError = () => { Console.WriteLine("[From Server]: Connection error encountered"); };
        }

        //add reactive

        static async void ParseMessage(string message)
        {
            Console.WriteLine($"[From Client]: {message}");
            if (message.Contains("GetVinyls"))
            {
                await SendVinyls();
            }
            else if (message.Contains("AddVinyl"))
            {
                var splited = message.Split(':');
                int vinylID = Serializer.IntFromJson(splited[1]);
                int vinylCount = Serializer.IntFromJson(splited[2]);

                await srvVinyls.AddVinyl(vinylID, vinylCount);

                await CurrentConnection.SendAsync("Confirm");
            }
            else if (message.Contains("RemoveVinyl"))
            {
                var splited = message.Split(':');
                int vinylID = Serializer.IntFromJson(splited[1]);
                int vinylCount = Serializer.IntFromJson(splited[2]);

                await srvVinyls.RemoveStockVinyl(vinylID, vinylCount);

                await CurrentConnection.SendAsync("Confirm");
            }
        }

        static async Task SendVinyls()
        {
            await CurrentConnection.SendAsync(Serializer.AllDataToJson(srvVinyls));
        }
    }
}
