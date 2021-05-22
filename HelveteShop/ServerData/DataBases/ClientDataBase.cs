using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace ServerData
{
    public class ClientDataBase : IDataBase<IClient>
    {
        private readonly DataContext dataContext;
        private readonly object itemLock = new object();

        public ClientDataBase()
        {
            this.dataContext = DataContext.Instance;
        }

        public bool Add(IClient item)
        {
            dataContext?.Clients?.Add(item);
            return true;
        }

        public IEnumerable<IClient> GetAll()
        {
            return dataContext?.Clients;
        }

        public IClient Get(int id)
        {
            return dataContext.Clients.Find(client => client.ID == id);
        }

        public bool Remove(int id)
        {
            return dataContext.Clients.Remove(dataContext.Clients.Find(client => client.ID == id));
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
