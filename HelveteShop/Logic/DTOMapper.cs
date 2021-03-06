using System;
using System.Collections.Generic;
using System.Text;
using ClientData;

namespace ClientLogic
{
    public static class DTOMapper
    {
        public static ClientDTO Map(Client client)
        {
            ClientDTO clientDTO = new ClientDTO
            {
                ID = client.ID,
                Name = client.name,
                Address = client.address
            };

            return clientDTO;
        }

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

        public static VinylDTO Map(Vinyl vinyl)
        {
            VinylDTO vinylDTO = new VinylDTO()
            {
                ID = vinyl.ID,
                Title = vinyl.Title,
                Band = vinyl.Band,
                Price = vinyl.Price,
                inStock = vinyl.InStock
            };

            return vinylDTO;
        }

        public static VinylDTO Map(IVinyl vinyl)
        {
            VinylDTO vinylDTO = new VinylDTO()
            {
                ID = vinyl.ID,
                Title = vinyl.Title,
                Band = vinyl.Band,
                Price = vinyl.Price,
                inStock = vinyl.InStock
            };

            vinylDTO.Band = vinyl.Band;

            return vinylDTO;
        }

        public static IVinyl Map(VinylDTO vinyl)
        {
            return new Vinyl(vinyl.ID, vinyl.Title, vinyl.Band, vinyl.Price, vinyl.inStock);
        }

        public static List<VinylDTO> MapVinylList(List<Vinyl> vinyls)
        {
            List<VinylDTO> vinylsDTO = new List<VinylDTO>();
            foreach (Vinyl vinyl in vinyls)
            {
                VinylDTO newVinylDTO= Map(vinyl);
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
                VinylBand = order.vinyl.Band,
                VinylTitle = order.vinyl.Title,
                VinylPrice = order.vinyl.Price
            };

            return orderDTO;
        }

        public static Order Map(OrderDTO order)
        {
            return new Order();
        }
    }
}
