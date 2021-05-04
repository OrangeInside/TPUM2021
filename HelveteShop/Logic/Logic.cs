using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class Logic
    {
        private static IClientsManager clientsManager = null;
        private static IVinylsManager vinylsManager = null;
        private static IOrdersManager ordersManager = null;

        public static IClientsManager GetClientsManager()
        {
            if (clientsManager == null)
            {
                clientsManager = new ClientsManager();
            }

            return clientsManager;
        }
        public static IVinylsManager GetVinylsManager()
        {
            if (vinylsManager == null)
            {
                vinylsManager = new VinylsManager();
            }

            return vinylsManager;
        }

        public static IOrdersManager GetOrdersManager()
        {
            if (ordersManager == null)
            {
                ordersManager = new OrdersManager();
            }

            return ordersManager;
        }
    }
}
