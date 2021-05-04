using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public partial class DataBase
    {
        public DataContext dataContext;

        public DataBase(IDataGenerator dataGenerator)
        {
            dataContext = dataGenerator.Generate();
        }

        #region Clients
        public void AddClient(Client client)
        {
            if (dataContext.clients.Contains(client))
            {
                throw new Exception("This collection already contains that object.");
            }

            dataContext.clients.Add(client);
        }

        public void RemoveClient(Client client)
        {
            if (!dataContext.clients.Contains(client))
            {
                throw new Exception("Can't remove item that doesn't exist in given collection");
            }
            dataContext.clients.Remove(client);
        }

        public Client GetClient(string name)
        {
            return dataContext.clients.Find(givenClient => (givenClient.name.Equals(name)));
        }

        public void UpdateClient(Client client)
        {
            Client clientFromDataBase = GetClient(client.name);
            
            if (clientFromDataBase == null)
            {
                throw new Exception("There is no client with name " + clientFromDataBase.name);
            }

            clientFromDataBase.address = client.address;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return dataContext.clients;
        }
        #endregion

        #region Vinyls
        public void AddVinyl(Vinyl vinyl)
        {
            if (dataContext.vinyls.Contains(vinyl))
            {
                throw new Exception("This collection already contains that object.");
            }

            dataContext.vinyls.Add(vinyl);
        }

        public void RemoveVinyl(Vinyl vinyl)
        {
            if (!dataContext.vinyls.Contains(vinyl))
            {
                throw new Exception("Can't remove item that doesn't exist in given collection");
            }
            dataContext.vinyls.Remove(vinyl);
        }

        public Vinyl GetVinyl(string title)
        {
            return dataContext.vinyls.Find(givenVinyl => (givenVinyl.title.Equals(title)));
        }

        public void UpdateVinyl(Vinyl vinyl)
        {
            Vinyl vinylFromDataBase = GetVinyl(vinyl.title);
            
            if (vinylFromDataBase == null)
            {
                throw new Exception("There is no vinyl with title " + vinylFromDataBase.title);
            }
            vinylFromDataBase.price = vinyl.price;
        }

        public IEnumerable<Vinyl> GetAllVinyls()
        {
            return dataContext.vinyls;
        }

        #endregion

        #region Orders
        public void AddOrder(Order order)
        {
            if (dataContext.orders.Contains(order))
            {
                throw new Exception("This collection already contains that object.");
            }

            dataContext.orders.Add(order);
        }

        public void RemoveOrder(int order)
        {
            if (dataContext.orders.Count <= order)
            {
                throw new Exception("Can't remove item that doesn't exist in given collection");
            }
            dataContext.orders.RemoveAt(order);
        }

        public Order GetOrder(int id)
        {
            return (Order)dataContext.orders.Where(givenOrder => givenOrder.ID.Equals(id));
        }

        public void UpdateOrder(Order order)
        {
            Order orderFromDataBase = GetOrder(order.ID);
            if (orderFromDataBase == null)
            {
                throw new Exception("There is no order with GUID " + orderFromDataBase.ID);
            }
            orderFromDataBase.vinyl = order.vinyl;
            orderFromDataBase.client = order.client;
        }

        public void AddOrderToArchive(Order order)
        {
            if (dataContext.ordersArchive.Contains(order))
            {
                throw new Exception("This collection already contains that object.");
            }
            dataContext.ordersArchive.Add(order);
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

    }


}
