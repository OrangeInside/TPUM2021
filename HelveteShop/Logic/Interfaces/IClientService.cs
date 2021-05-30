using System;
using System.Collections.Generic;
using System.Text;

namespace ClientLogic
{
    public interface IClientService
    {
        ClientDTO GetClient(int id);
        IEnumerable<ClientDTO> GetClients();

    }
}
