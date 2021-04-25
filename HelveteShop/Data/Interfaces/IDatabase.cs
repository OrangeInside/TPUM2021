using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IDatabase
    {
        public List<Vinyl> Vinyls { get; set; }
        public List<Client> Clients { get; set; }
        public List<Order> Orders { get; set; }
    }
}
