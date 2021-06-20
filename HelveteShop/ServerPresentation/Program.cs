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

        private static VinylTracker vinylTracker;
        private static VinylObserver vinylObserver;

        static async Task Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Action<string> consoleLog = Console.WriteLine;

            timeTracker = new TimeTracker();

            stockUpdater = new StockUpdater();

            stockUpdater.Subscribe(timeTracker, UpdateStock);

            vinylTracker = new VinylTracker();

            vinylObserver = new VinylObserver();

            vinylObserver.Subscribe(vinylTracker, (x) => { _ = CurrentConnection.SendAsync(MessageParser.Create("OnNext", x, x.GetType().Name)); });

            await CreateServer();
        }

        public static async Task CreateServer()
        {
            await WebSocketServer.Server(8081, ConnectionHandler);
        }

        static void ConnectionHandler(WebSocketConnection webSocketConnection)
        {
            CurrentConnection = webSocketConnection;
            webSocketConnection.onMessage = ParseMessage;
            webSocketConnection.onClose = () => { Console.WriteLine("[From Server]: Connection closed"); };
            webSocketConnection.onError = () => { Console.WriteLine("[From Server]: Connection error encountered"); };
        }

        private static VinylDTO vinylSubscr = null;

        static async void ParseMessage(string message)
        {
            Message msg = MessageParser.Deserialize(message);

            Console.WriteLine($"[From Client]: {message}");

            switch (msg.Command)
            {
                case "UpdateDataRequest":
                    _ = UpdateEveryVinylSend();
                    break;
                case "AddVinyl":
                    var vinylToAdd = MessageParser.DeserializeType<VinylDTO>(msg.Data.ToString());
                    await srvVinyls.AddVinyl(vinylToAdd.ID, vinylToAdd.InStock);
                    _ = ConfirmSend();
                    break;
                case "RemoveVinyl":
                    var vinylToRemove = MessageParser.DeserializeType<int>(msg.Data.ToString());

                    await srvVinyls.RemoveStockVinyl(vinylToRemove, 1);
                    _ = ConfirmSend();
                    break;
                case "TimeInterval":
                    float timeInterval = MessageParser.DeserializeType<float>(msg.Data.ToString());

                    timeTracker.ProcessTimeInterval(timeInterval);
                    break;
                case "Subscribe":
                    if (vinylSubscr == null)
                    {
                        vinylSubscr = MessageParser.DeserializeType<VinylDTO>(msg.Data.ToString());
                        _ = Task.Run(() => RemoveOneVinylInTime());
                        _ = ConfirmSend();
                    }
                    break;
                case "Unsubscribe":
                    var vinyl = MessageParser.DeserializeType<VinylDTO>(msg.Data.ToString());
                    if (vinyl.ID == vinylSubscr.ID)
                    {
                        vinylSubscr = null;
                        _ = ConfirmSend();
                    }
                    break;
            }
        }

        static async Task RemoveOneVinylInTime()
        {
            while (vinylSubscr != null)
            {
                System.Threading.Thread.Sleep(5000);

                if (vinylSubscr == null)
                    continue;

                await srvVinyls.RemoveStockVinyl(vinylSubscr.ID, 1);

                var updatedVinyl = srvVinyls.GetVinyl(vinylSubscr.ID).Result;

                vinylTracker.Track(DTOMapper.Map(updatedVinyl));
            }
        }

        static async void UpdateStock()
        {
            if (CurrentConnection != null)
            {
                await srvVinyls.UpdateStock();
                await UpdateEveryVinylSend();
                //await SendVinyls();
                Console.WriteLine("[From Server]: Update vinyls in stock");
            }
        }

        static async Task SendVinyls()
        {
            await CurrentConnection.SendAsync(Serializer.AllDataToJson(srvVinyls));
            Console.WriteLine("[From Server]: Send Vinyls Data");
        }

        static async Task ConfirmSend()
        {
            await CurrentConnection.SendAsync(MessageParser.Create("Confirm", "", "void"));
        }

        static async Task UpdateEveryVinylSend()
        {
            var vinyls = srvVinyls.GetAllVinyls().Result;
            await CurrentConnection.SendAsync(MessageParser.Create("UpdateAll", vinyls, vinyls.GetType().Name));
        }
    }
}
