using System;
using System.Collections.Generic;
using System.Text;
using ClientData;

namespace ClientLogic
{
    public class ClientService : IClientService
    {
        private readonly IDataBase<IClient> clientDataBase;

        public ClientService(IDataBase<IClient> clientDataBase)
        {
            this.clientDataBase = clientDataBase;
        }

        public ClientDTO GetClient(int id)
        {
            return DTOMapper.Map(clientDataBase.Get(id));
        }

        public IEnumerable<ClientDTO> GetClients()
        {
            IEnumerable<IClient> clients = clientDataBase.GetAll();
            List<ClientDTO> clientsDTO = new List<ClientDTO>();
            foreach (var client in clients)
            {
                clientsDTO.Add(DTOMapper.Map(client));
            }

            return clientsDTO;
        }

    }
}
