using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModel.Interfaces
{
    public interface IDataBase<T> where T : IData
    {
        void Add(T item);
        bool Remove(T item);
        T GetClient(int id);
        bool Update(T item, int id);
        IEnumerable<T> GetAll();

        /*
        bool AddClient(IClient client);
        bool RemoveClient(IClient client);
        IClient GetClient(string name);
        IClient GetClient(int id);
        bool UpdateClient(IClient client);
        IEnumerable<IClient> GetAllClients();


        bool AddVinyl(IVinyl vinyl);
        bool RemoveVinyl(IVinyl vinyl);
        IVinyl GetVinyl(string title);
        IVinyl GetVinyl(int id);
        bool UpdateVinyl(IVinyl vinyl);
        IEnumerable<IVinyl> GetAllVinyls();


        bool AddOrder(IOrder order);
        bool RemoveOrder(int order);
        IOrder GetOrder(int id);
        bool UpdateOrder(IOrder order);
        //bool AddOrderToArchive(IOrder order);
        IEnumerable<IOrder> GetAllOrders();
        //IEnumerable<IOrder> GetAllArchiveOrders();
        */
    }
}
