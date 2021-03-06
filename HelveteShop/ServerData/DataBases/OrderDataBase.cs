using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerData
{
    public class OrderDataBase : IDataBase<IOrder>
    {
        private readonly DataContext dataContext;
        private readonly object itemLock = new object();

        public OrderDataBase()
        {
            this.dataContext = DataContext.Instance;
        }

        public event Action DataChanged;

        public void Add(IOrder item)
        {
            dataContext?.Orders?.Add(item);
        }

        public IEnumerable<IOrder> GetAll()
        {
            return dataContext?.Orders;
        }

        public IOrder GetClient(int id)
        {
            return dataContext.Orders.Find(order => order.ID == id);
        }

        public Task Refresh()
        {
            throw new NotImplementedException();
        }

        public bool Remove(IOrder item)
        {
            return dataContext.Orders.Remove(item);
        }

        public bool Update(IOrder item, int id)
        {
            IOrder targetOrder = dataContext.Orders.Find(order => order.ID == id);

            if (targetOrder == null)
                return false;
            else
            {
                lock (itemLock)
                {
                    targetOrder.client = item.client;
                    targetOrder.vinyl = item.vinyl;
                }

                return true;
            }
        }

        /*bool IDataBase<IOrder>.Add(IOrder item)
        {
            throw new NotImplementedException();
        }*/

        Task<bool> IDataBase<IOrder>.Add(IOrder item)
        {
            throw new NotImplementedException();
        }

        IOrder IDataBase<IOrder>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IOrder> IDataBase<IOrder>.GetAll()
        {
            throw new NotImplementedException();
        }

        bool IDataBase<IOrder>.Remove(int id)
        {
            throw new NotImplementedException();
        }

        bool IDataBase<IOrder>.Update(IOrder item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
