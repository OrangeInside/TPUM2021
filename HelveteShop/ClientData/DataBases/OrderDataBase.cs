using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace ClientData
{
    class OrderDataBase : IDataBase<IOrder>
    {
        private readonly DataContext dataContext;

        public OrderDataBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

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
                targetOrder.client = item.client;
                targetOrder.vinyl = item.vinyl;
                return true;
            }
        }
    }
}
