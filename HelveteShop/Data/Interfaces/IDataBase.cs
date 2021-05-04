using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IDataBase
    {
        bool AddClient(Client client);
        bool RemoveClient(Client client);
        Client GetClient(string name);
        Client GetClient(int id);
        bool UpdateClient(Client client);
        IEnumerable<Client> GetAllClients();


        bool AddVinyl(Vinyl vinyl);
        bool RemoveVinyl(Vinyl vinyl);
        Vinyl GetVinyl(string title);
        Vinyl GetVinyl(int id);
        bool UpdateVinyl(Vinyl vinyl);
        IEnumerable<Vinyl> GetAllVinyls();


        bool AddOrder(Order order);
        bool RemoveOrder(int order);
        Order GetOrder(int id);
        bool UpdateOrder(Order order);
        bool AddOrderToArchive(Order order);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllArchiveOrders();
    }
}
