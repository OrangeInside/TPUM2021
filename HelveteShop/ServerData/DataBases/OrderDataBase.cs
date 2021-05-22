﻿using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

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
                lock (itemLock)
                {
                    targetOrder.client = item.client;
                    targetOrder.vinyl = item.vinyl;
                }

                return true;
            }
        }
    }
}