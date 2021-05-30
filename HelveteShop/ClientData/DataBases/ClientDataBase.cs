using System;
using System.Collections.Generic;
using CommonModel;

namespace ClientData
{
    class ClientDataBase : IDataBase<IClient>
    {
        private readonly DataContext dataContext;

        public ClientDataBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Add(IClient item)
        {
            dataContext?.Clients?.Add(item);
        }

        public IClient Get(int id)
        {
            throw new NotImplementedException();
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

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IClient item, int id)
        {
            IClient targetClient = dataContext.Clients.Find(client => client.ID == id);

            if (targetClient == null)
                return false;
            else
            {
                targetClient.name = item.name;
                targetClient.address = item.address;
                return true;
            }
        }

        bool IDataBase<IClient>.Add(IClient item)
        {
            throw new NotImplementedException();
        }
    }
}
