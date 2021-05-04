using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IDataBase
    {
        void AddClient(Client client);
        void RemoveClient(Client client);
        Client GetClient(string name);
        void UpdateClient(Client client);
        IEnumerable<Client> GetAllClients();


        void AddVinyl(Vinyl vinyl);
        void RemoveVinyl(Vinyl vinyl);
        Vinyl GetVinyl(string title);
        void UpdateVinyl(Vinyl vinyl);
        IEnumerable<Vinyl> GetAllVinyls();


        void AddOrder(Order order);
        void RemoveOrder(int order);
        Order GetOrder(int id);
        void UpdateOrder(Order order);
        void AddOrderToArchive(Order order);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllArchiveOrders();
    }
}
