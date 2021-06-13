using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientData
{
    public class ClientDataBase : IDataBase<IClient>
    {
        private readonly DataContext dataContext;

        private static ClientDataBase instance;

        public event Action DataChanged;

        public static ClientDataBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClientDataBase();

                return instance;
            }

            private set => instance = value;
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

        Task<bool> IDataBase<IClient>.Add(IClient item)
        {
            throw new NotImplementedException();
        }

        public Task Refresh()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id, int count)
        {
            throw new NotImplementedException();
        }
    }
}
