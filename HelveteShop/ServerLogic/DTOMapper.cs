using System;
using System.Collections.Generic;
using CommonModel;
using CommonModel.Interfaces;

namespace ServerLogic
{
    public class DTOMapper
    {
        public static ClientDTO Map(IClient client)
        {
            ClientDTO clientDTO = new ClientDTO
            {
                ID = client.ID,
                Name = client.name,
                Address = client.address
            };

            return clientDTO;
        }

        public static IClient Map(ClientDTO clientDTO)
        {
            Client client = new Client(clientDTO.ID, clientDTO.Name, clientDTO.Address);

            return client;
        }

        public static VinylDTO Map(IVinyl vinyl)
        {
            VinylDTO vinylDTO = new VinylDTO
            {
                ID = vinyl.ID,
                Title = vinyl.title,
                Band = vinyl.band,
                Price = vinyl.price
            };

            return vinylDTO;
        }

        public static IVinyl Map(VinylDTO vinylDTO)
        {
            Vinyl vinyl = new Vinyl(vinylDTO.ID, vinylDTO.Title, vinylDTO.Band, vinylDTO.Price);

            return vinyl;
        }

        public static List<VinylDTO> MapVinylList(List<Vinyl> vinyls)
        {
            List<VinylDTO> vinylsDTO = new List<VinylDTO>();
            foreach (Vinyl vinyl in vinyls)
            {
                VinylDTO newVinylDTO = Map(vinyl);
                vinylsDTO.Add(newVinylDTO);
            }

            return vinylsDTO;
        }

        public static OrderDTO Map(IOrder order)
        {
            OrderDTO orderDTO = new OrderDTO
            {
                ID = order.ID,
                ClientID = order.client.ID,
                ClientName = order.client.name,
                ClientAddress = order.client.address,
                VinylID = order.vinyl.ID,
                VinylBand = order.vinyl.band,
                VinylTitle = order.vinyl.title,
                VinylPrice = order.vinyl.price
            };

            return orderDTO;
        }

        public static IOrder Map(OrderDTO orderDTO)
        {
            Client client = new Client(orderDTO.ClientID, orderDTO.ClientName, orderDTO.ClientAddress);
            Vinyl vinyl = new Vinyl(orderDTO.VinylID, orderDTO.VinylTitle, orderDTO.VinylBand, orderDTO.VinylPrice);

            Order order = new Order(orderDTO.ID, client, vinyl);

            return order;
        }
    }
}
