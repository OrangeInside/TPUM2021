using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Logic
{
    public class ClientsManager : IClientsManager
    {
        public event Action OnRefreshClients;

        private IDataBase dataBase = null;

        public ClientsManager()
        {
            dataBase = Data.Data.GetDataBase();
        }

        public List<ClientDTO> GetAllClientsAsDTO()
        {
            List<ClientDTO> listToReturn = new List<ClientDTO>();

            foreach (Client client in dataBase.GetAllClients())
            {
                listToReturn.Add(DTOMapper.Map(client));
            }

            return listToReturn;
        }

        public bool AddClient(ClientDTO clientToAdd)
        {
            if (clientToAdd.Name != "" && clientToAdd.Address != "")
            {
                List<ClientDTO> clients = GetAllClientsAsDTO();

                int idForClient = 0;

                foreach (ClientDTO client in clients)
                {
                    if (idForClient == client.ID)
                        idForClient++;
                    else
                        break;
                }

                Client newClientData = new Client(idForClient, clientToAdd.Name, clientToAdd.Address);

                dataBase.AddClient(newClientData);

                OnRefreshClients?.Invoke();

                return true;
            }
            return false;
        }

    }
}
