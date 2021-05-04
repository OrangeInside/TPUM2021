using System;
using System.Collections.Generic;
using System.Text;
using Logic.DTO;
using Data;

namespace Logic
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

        public static VinylDTO Map(Vinyl vinyl)
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

        public static OrderDTO Map(Order order)
        {
            OrderDTO orderDTO = new OrderDTO
            {
                guid = order.guid,
                vinyls = MapVinylList(order.vinyls),
                client = Map(order.client),
            };

            return orderDTO;
        }
    }
}
