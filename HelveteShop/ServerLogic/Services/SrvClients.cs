using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonModel;
using ServerData;

namespace ServerLogic
{
    public class SrvClients : IClientServicecs
    {
        private IDataBase<IClient> clientDataBase = null;

        public SrvClients()
        {
            if (clientDataBase == null)
            {
                clientDataBase = new ClientDataBase();
                clientDataBase.Add(new Client(0, "Test", "Test"));
                clientDataBase.Add(new Client(1, "Test2", "Test2"));
            }
        }

        public Task<bool> AddClient(ClientDTO client)
        {
            return Task.FromResult(true);
            //return await Task.FromResult(clientDataBase.Add(DTOMapper.Map(client)));
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClients()
        {
            var clients = clientDataBase.GetAll();

            List<ClientDTO> clientsList = new List<ClientDTO>();

            foreach (var c in clients)
            {
                clientsList.Add(DTOMapper.Map(c));
            }

            return await Task.FromResult(clientsList);
        }

        public async Task<ClientDTO> GetClient(int id)
        {
            return await Task.FromResult(DTOMapper.Map(clientDataBase.Get(id)));
        }

        public async Task<bool> RemoveClient(int id)
        {
            return await Task.FromResult(clientDataBase.Remove(id));
        }

        public async Task<bool> UpdateClient(ClientDTO client, int id)
        {
            return await Task.FromResult(clientDataBase.Update(DTOMapper.Map(client), id));
        }
    }
}
