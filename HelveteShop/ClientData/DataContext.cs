using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommonModel;
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

            await WebSocketClient.CurrentConnection.SendAsync("UpdateDataRequest");

            while (isAwaitingResponse) { }
        }

        public async Task RequestWithConfirmation(string request)
        {
            isAwaitingConfirmation = true;

            await WebSocketClient.CurrentConnection.SendAsync(request);

            while (isAwaitingConfirmation) { }
        }

        public void ReceiveData(string data)
        {
            var split = data.Split('[');
            if (string.Compare(split[0], "Vinyls", StringComparison.Ordinal) == 0)
            {
                lock (vinylsLock)
                {
                    Vinyls.Clear();

                    var toDeserialize = split[1].Insert(0, "[");
                    var deserialized = JsonSerializer.Deserialize<List<Vinyl>>(toDeserialize);
                    Vinyls = new List<IVinyl>(deserialized);
                    VinylsChanged?.Invoke();
                }

                isAwaitingResponse = false;
            }
            else if (string.Compare(split[0], "Confirm", StringComparison.Ordinal) == 0)
            {
                isAwaitingConfirmation = false;
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
