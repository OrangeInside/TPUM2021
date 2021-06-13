using System;
using System.Collections.Generic;
using System.Text;
using ClientData;

namespace ClientLogic
{
    public class OrderService : IOrderService
    {
        private readonly IDataBase<IOrder> orderDataBase;

        public OrderService(IDataBase<IOrder> orderDataBase)
        {
            this.orderDataBase = orderDataBase;
        }

        public OrderDTO GetOrder(int id)
        {
            return DTOMapper.Map(orderDataBase.Get(id));
        }

        public IEnumerable<OrderDTO> GetOrders()
        {
            IEnumerable<IOrder> orders = orderDataBase.GetAll();
            List<OrderDTO> ordersDTO = new List<OrderDTO>();
            foreach (var order in orders)
            {
                ordersDTO.Add(DTOMapper.Map(order));
            }

            return ordersDTO;
        }
    }
}
