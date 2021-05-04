using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IOrdersManager
    {
        event Action OnRefreshOrders;
        List<OrderDTO> GetAllOrdersAsDTO();
        bool AddOrder(OrderDTO orderDTO);
    }
}
