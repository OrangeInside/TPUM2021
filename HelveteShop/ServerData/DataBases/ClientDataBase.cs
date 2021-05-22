using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace ServerData
{
    class ClientDataBase : IDataBase<IClient>
    {
        private readonly DataContext dataContext;
        private readonly object itemLock = new object();

        public ClientDataBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Add(IClient item)
        {
            dataContext?.Clients?.Add(item);
        }

        public IEnumerable<IClient> GetAll()
        {
            return dataContext?.Clients;
        }

        public IClient GetClient(int id)
        {
            return dataContext.Clients.Find(client => client.ID == id);
        }

        public bool Remove(IClient item)
        {
            return dataContext.Clients.Remove(item);
        }

        public bool Update(IClient item, int id)
        {
            IClient targetClient = dataContext.Clients.Find(client => client.ID == id);

            if (targetClient == null)
                return false;
            else
            {
                lock (itemLock)
                {
                    targetClient.name = item.name;
                    targetClient.address = item.address;
                }

                return true;
            }
        }
    }
}
