using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public static class Logic
    {
        private static ClientsManager clientsManager = null;
        private static VinylsManager vinylsManager = null;
        private static OrdersManager ordersManager = null;

        public static ClientsManager GetClientsManager()
        {
            if (clientsManager == null)
            {
                clientsManager = new ClientsManager();
            }

            return clientsManager;
        }
        public static VinylsManager GetVinylsManager()
        {
            if (vinylsManager == null)
            {
                vinylsManager = new VinylsManager();
            }

            return vinylsManager;
        }

        public static OrdersManager GetOrdersManager()
        {
            if (ordersManager == null)
            {
                ordersManager = new OrdersManager();
            }

            return ordersManager;
        }
    }
}
