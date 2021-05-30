using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    /*public partial class DataBase : IDataBase
    {
        private DataContext dataContext;

        public DataBase(IDataGenerator dataGenerator)
        {
            dataContext = dataGenerator.Generate();
        }

        #region Clients
        public bool AddClient(Client client)
        {
            if (dataContext.clients.Contains(client))
            {
                return false;
            }

            dataContext.clients.Add(client);

            return true;
        }

        public bool RemoveClient(Client client)
        {
            if (!dataContext.clients.Contains(client))
            {
                return false;
            }
            dataContext.clients.Remove(client);

            return true;
        }

        public Client GetClient(string name)
        {
            return dataContext.clients.Find(givenClient => (givenClient.name.Equals(name)));
        }

        public Client GetClient(int id)
        {
            return dataContext.clients.Find(givenClient => (givenClient.ID.Equals(id)));
        }

        public bool UpdateClient(Client client)
        {
            Client clientFromDataBase = GetClient(client.name);
            
            if (clientFromDataBase == null)
            {
                return false;
            }

            clientFromDataBase.address = client.address;

            return true;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return dataContext.clients;
        }
        #endregion

        #region Vinyls
        public bool AddVinyl(Vinyl vinyl)
        {
            if (dataContext.vinyls.Contains(vinyl))
            {
                return false;
            }

            dataContext.vinyls.Add(vinyl);

            return true;
        }

        public bool RemoveVinyl(Vinyl vinyl)
        {
            if (!dataContext.vinyls.Contains(vinyl))
            {
                return false;
            }
            dataContext.vinyls.Remove(vinyl);

            return true;
        }

        public Vinyl GetVinyl(string title)
        {
            return dataContext.vinyls.Find(givenVinyl => (givenVinyl.title.Equals(title)));
        }

        public Vinyl GetVinyl(int id)
        {
            return dataContext.vinyls.Find(givenVinyl => (givenVinyl.ID.Equals(id)));
        }

        public bool UpdateVinyl(Vinyl vinyl)
        {
            Vinyl vinylFromDataBase = GetVinyl(vinyl.title);
            
            if (vinylFromDataBase == null)
            {
                return false;
            }
            vinylFromDataBase.price = vinyl.price;

            return true;
        }

        public IEnumerable<Vinyl> GetAllVinyls()
        {
            return dataContext.vinyls;
        }

        #endregion

        #region Orders
        public bool AddOrder(Order order)
        {
            if (dataContext.orders.Contains(order))
            {
                return false;
            }

            dataContext.orders.Add(order);

            return true;
        }

        public bool RemoveOrder(int order)
        {
            if (dataContext.orders.Count <= order)
            {
                return false;
            }
            dataContext.orders.RemoveAt(order);

            return true;
        }

        public Order GetOrder(int id)
        {
           /// return (Order)dataContext.orders.Where(givenOrder => givenOrder.ID.Equals(id));
            return dataContext.orders?.Find(x => x.ID == id);
        }

        public bool UpdateOrder(Order order)
        {
            Order orderFromDataBase = GetOrder(order.ID);
            if (orderFromDataBase == null)
            {
                return false;
            }
            orderFromDataBase.vinyl = order.vinyl;
            orderFromDataBase.client = order.client;

            return true;
        }

        public bool AddOrderToArchive(Order order)
        {
            if (dataContext.ordersArchive.Contains(order))
            {
                return false;
            }
            dataContext.ordersArchive.Add(order);

            return true;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return dataContext.orders;
        }

        public IEnumerable<Order> GetAllArchiveOrders()
        {
            return dataContext.orders;
        }

        #endregion

    }*/


}
