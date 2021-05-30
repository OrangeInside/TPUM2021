using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonModel;
using CommonModel;
using ServerData;

namespace ServerLogic
{
    public class SrvOrders : IOrderServices
    {
        private IDataBase<IOrder> orderDataBase = null;

        public SrvOrders()
        {
            if (orderDataBase == null)
            {
                orderDataBase = new OrderDataBase();
            }
        }

        public Task<bool> AddOrder(OrderDTO order)
        {
            return Task.FromResult(true);
            //return await Task.FromResult(orderDataBase.Add(DTOMapper.Map(order)));
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var orders = orderDataBase.GetAll();

            List<OrderDTO> ordersList = new List<OrderDTO>();

            foreach (var o in orders)
            {
                ordersList.Add(DTOMapper.Map(o));
            }

            return await Task.FromResult(ordersList);
        }

        public async Task<OrderDTO> GetOrder(int id)
        {
            return await Task.FromResult(DTOMapper.Map(orderDataBase.Get(id)));
        }

        public async Task<bool> RemoveOrder(int id)
        {
            return await Task.FromResult(orderDataBase.Remove(id));
        }

        public async Task<bool> UpdateOrder(OrderDTO order, int id)
        {
            return await Task.FromResult(orderDataBase.Update(DTOMapper.Map(order), id));
        }
    }
}
