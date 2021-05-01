using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DTO
{
    public class OrderDTO
    {
        public Guid guid { get; set; }
        public List<VinylDTO> vinyls { get; set; }
        public ClientDTO client { get; set; }

    }
}
