using System;
using System.Globalization;
using System.Threading.Tasks;
using ServerLogic;

namespace ServerPresentation
{
    public class Program
    {
        private static WebSocketConnection CurrentConnection;
        private static readonly IVinylServices srvVinyls = new SrvVinyls();

        private static StockUpdater stockUpdater;
        private static TimeTracker timeTracker;

        static async Task Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Action<string> consoleLog = Console.WriteLine;

            timeTracker = new TimeTracker();

            stockUpdater.Subscribe(timeTracker, UpdateStock);

            await CreateServer();
        }

        public static async Task CreateServer()
        {
            await WebSocketServer.Server(8081, ConnectionHandler);
        }

        //private static Timer timer = null;

        static void ConnectionHandler(WebSocketConnection webSocketConnection)
        {
            CurrentConnection = webSocketConnection;
            webSocketConnection.onMessage = ParseMessage;
            webSocketConnection.onClose = () => { Console.WriteLine("[From Server]: Connection closed"); };
            webSocketConnection.onError = () => { Console.WriteLine("[From Server]: Connection error encountered"); };

            //timer = new Timer(10000);
            //timer.OnTimerReach += UpdateStock;
        }

        static async void ParseMessage(string message)
        {
            Console.WriteLine($"[From Client]: {message}");
            if (message.Contains("UpdateDataRequest"))
            {
                Console.WriteLine("[From Server]: Prepare data");
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
            else if (message.Contains("TimeInterval"))
            {
                var splited = message.Split(':');
                float timeInterval = Serializer.FloatFromJson(splited[1]);

                timeTracker.ProcessTimeInterval(timeInterval);
            }
        }

        static async void UpdateStock()
        {
            if (CurrentConnection != null)
            {
                await srvVinyls.UpdateStock();
                await SendVinyls();
                Console.WriteLine("[From Server]: Update vinyls in stock");
            }
        }

        static async Task SendVinyls()
        {
            await CurrentConnection.SendAsync(Serializer.AllDataToJson(srvVinyls));
            Console.WriteLine("[From Server]: Send Vinyls Data");
        }
    }
}
