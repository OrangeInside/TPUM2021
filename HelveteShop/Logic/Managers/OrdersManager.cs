using System;
using System.Collections.Generic;
using System.Text;
using Logic.DTO;

namespace Logic.Managers
{
    using Data;

    public class OrdersManager
    {
        public event Action OnRefreshOrders;

        private DataBase dataBase = null;

        public OrdersManager()
        {
            dataBase = Data.GetDataBase();
        }

        public List<OrderDTO> GetAllOrdersAsDTO()
        {
            List<OrderDTO> listToReturn = new List<OrderDTO>();

            foreach (Order order in dataBase.GetAllOrders())
            {
                listToReturn.Add(DTOMapper.Map(order));
            }

            return listToReturn;
        }

        public bool AddOrder(OrderDTO orderDTO)
        {
            Client c = dataBase.GetClient(orderDTO.ClientName);
            Vinyl v = dataBase.GetVinyl(orderDTO.VinylTitle);

            if (c != null && v != null)
            {
                List<OrderDTO> orders = GetAllOrdersAsDTO();

                int idForOrder = 0;

                foreach (OrderDTO order in orders)
                {
                    if (idForOrder == order.ID)
                        idForOrder++;
                    else
                        break;
                }

                Order newOrder = new Order(idForOrder, c, v);

                dataBase.AddOrder(newOrder);

                OnRefreshOrders?.Invoke();

                return true;
            }
            return false;
        }

        /*public bool AddVinyl(VinylDTO vinylToAdd)
        {
            if (vinylToAdd.Title != "" && vinylToAdd.Band != "")
            {
                List<VinylDTO> vinyls = GetAllVinylsAsDTO();

                int idForVinyl = 0;

                foreach (VinylDTO vinyl in vinyls)
                {
                    if (idForVinyl == vinyl.ID)
                        idForVinyl++;
                    else
                        break;
                }

                Vinyl newVinylData = new Vinyl(idForVinyl, vinylToAdd.Title, vinylToAdd.Band, vinylToAdd.Price);

                dataBase.AddVinyl(newVinylData);

                OnRefreshVinyls?.Invoke();

                return true;
            }
            return false;
        }*/
    }
}
