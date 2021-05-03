using System;
using System.Collections.Generic;
using System.Text;
using Logic.Managers;

namespace Logic
{
    public static class Logic
    {
        private static ClientsManager clientsManager = null;

        public static ClientsManager GetClientsManager()
        {
            if (clientsManager == null)
            {
                clientsManager = new ClientsManager();
            }

            return clientsManager;
        }
    }
}
