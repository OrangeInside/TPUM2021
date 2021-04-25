using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class OrdersCollection : IItemCollection<Order>
    {
        private List<Order> orders = new List<Order>();

        public void Add(Order item)
        {
            orders.Add(item);
        }

        public Order[] GetAll()
        {
            return orders.ToArray();
        }

        public Order GetItemByID(int id)
        {
            foreach (Order o in orders)
            {
                if (o.ID == id)
                    return o;
            }

            return null;
        }

        public bool Remove(Order item)
        {
            if (orders.Contains(item))
            {
                orders.Remove(item);
                return true;
            }

            return false;
        }
    }
}
