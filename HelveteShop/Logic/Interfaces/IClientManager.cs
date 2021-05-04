using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IClientsManager
    {
        event Action OnRefreshClients;
        List<ClientDTO> GetAllClientsAsDTO();
        bool AddClient(ClientDTO clientToAdd);

    }
}
