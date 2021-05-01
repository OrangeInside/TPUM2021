using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IDatabase
    {
        List<Vinyl> Vinyls { get; set; }
        List<Client> Clients { get; set; }
        List<Order> Orders { get; set; }
    }
}
