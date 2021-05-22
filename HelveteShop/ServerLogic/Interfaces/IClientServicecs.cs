using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic
{
    public interface IClientServicecs
    {
        Task<ClientDTO> GetClient(int id);
        Task<IEnumerable<ClientDTO>> GetAllClients();
        Task<bool> AddClient(ClientDTO client);
        Task<bool> RemoveClient(ClientDTO client);
        Task<bool> UpdateClient(ClientDTO client, int id);
    }
}
