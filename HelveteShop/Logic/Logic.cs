using System;
using System.Collections.Generic;
using System.Text;

namespace ClientLogic
{
    public static class Logic
    {
        private static IClientService clientsManager = null;
        private static IVinylService vinylsManager = null;
        private static IOrderService ordersManager = null;

        public static IClientService GetClientsManager()
        {
            if (clientsManager == null)
            {
                clientsManager = new ClientsManager();
            }

            return clientsManager;
        }
        public static IVinylService GetVinylsManager()
        {
            if (vinylsManager == null)
            {
                vinylsManager = new VinylsManager();
            }

            return vinylsManager;
        }

        public static IOrderService GetOrdersManager()
        {
            if (ordersManager == null)
            {
                ordersManager = new OrdersManager();
            }

            return ordersManager;
        }
    }
}
