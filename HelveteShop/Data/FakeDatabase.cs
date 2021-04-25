using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class FakeDatabase : IDatabase
    {
        public List<Vinyl> Vinyls { get; set; }
        public List<Client> Clients { get; set; }
        public List<Order> Orders { get; set; }

        FakeDatabase()
        {
            Vinyls = new List<Vinyl>();
            Clients = new List<Client>();
            Orders = new List<Order>();

            Vinyls.Add(new Vinyl { Title = "Filosofem", Band = "Burzum", Price = 5.99M });
            Vinyls.Add(new Vinyl { Title = "Transylvanian Hunger", Band = "Darkthrone", Price = 3.99M });
            Vinyls.Add(new Vinyl { Title = "De Mysteriis Dom Sathanas", Band = "Mayhem", Price = 4.99M });
            Vinyls.Add(new Vinyl { Title = "Black Metal", Band = "Venom", Price = 2.99M });
            Vinyls.Add(new Vinyl { Title = "With Hearts Toward None", Band = "Mgla", Price = 1.99M });

            Clients.Add(new Client { Name = "Andrew", Adress = "Milorgveien 121" });
            Clients.Add(new Client { Name = "Kjetil", Adress = "Grenaderveien 128" });
            Clients.Add(new Client { Name = "Jon", Adress = "Tappenhaugen 124" });

            Orders.Add(new Order { ClientID = Clients[0].ID, vinyls = new List<Vinyl>() { Vinyls[2] } });
        }
    }
}
