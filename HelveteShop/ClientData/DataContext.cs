using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;

namespace ClientData
{
    public class DataContext
    {
        private static DataContext instance;
        public static DataContext Instance
        {
            get 
            {
                if (instance == null)
                    instance = new DataContext();

                return instance;
            }

            private set => instance = value;
        }

        public async Task RequestDataUpdate()
        {
            isAwaitingResponse = true;

            await WebSocketClient.CurrentConnection.SendAsync(MessageParser.Create("UpdateDataRequest", "", "void"));

            while (isAwaitingResponse) { }
        }

        public async Task RequestWithConfirmation(string request)
        {
            isAwaitingConfirmation = true;

            await WebSocketClient.CurrentConnection.SendAsync(request);

            while (isAwaitingConfirmation) { }
        }

        public async Task RequestWithoutConfirmation(string request)
        {
            await WebSocketClient.CurrentConnection.SendAsync(request);
        }

        public void ReceiveData(string data)
        {
            var msg = MessageParser.Deserialize(data);

            switch (msg.Command)
            {
                case "UpdateAll":

                    var objectToList = MessageParser.DeserializeType<List<Vinyl>>(msg.Data.ToString());

                    lock (vinylsLock)
                    {
                        Vinyls.Clear();

                        Vinyls = new List<IVinyl>(objectToList);
                    }

                    VinylsChanged?.Invoke();
                    isAwaitingResponse = false;
                    break;

                case "Confirm":
                    isAwaitingConfirmation = false;
                    break;
                case "OnNext":
                    var receivedVinyl = MessageParser.DeserializeType<Vinyl>(msg.Data.ToString());

                    var vinylToUpdate = Vinyls.Find((x) => x.ID == receivedVinyl.ID);

                    lock (vinylsLock)
                    {
                        vinylToUpdate.InStock = receivedVinyl.InStock;
                    }

                    VinylsChanged?.Invoke();
                    break;
            }
        }

        private bool isAwaitingConfirmation = false;
        private bool isAwaitingResponse = false;

        public event Action VinylsChanged;

        public List<IClient> Clients { get; set; } = new List<IClient>();
        public object clientsLock = new object();
        public List<IVinyl> Vinyls { get; set; } = new List<IVinyl>();
        public object vinylsLock = new object();
        public List<IOrder> Orders { get; set; } = new List<IOrder>();
        public object ordersLock = new object();
    }
}
