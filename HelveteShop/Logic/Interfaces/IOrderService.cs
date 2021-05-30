using System;
using System.Collections.Generic;
using System.Text;

namespace ClientLogic
{
    public interface IOrderService
    {
        OrderDTO GetOrder(int id);
        IEnumerable<OrderDTO> GetOrders();
    }
}
