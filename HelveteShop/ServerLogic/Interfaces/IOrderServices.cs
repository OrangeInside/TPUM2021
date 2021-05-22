using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogic
{
    public interface IOrderServices
    {
        Task<OrderDTO> GetOrder(int id);
        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<bool> AddOrder(OrderDTO order);
        Task<bool> RemoveOrder(OrderDTO order);
        Task<bool> UpdateOrder(OrderDTO order, int id);
    }
}
