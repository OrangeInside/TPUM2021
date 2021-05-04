using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class DataFactory : IDataGenerator
    {
        public DataContext Generate()
        {
            DataContext data = new DataContext();

            data.clients.Add(new Client(0, "Odo", "Milorgveien 121"));
            data.clients.Add(new Client(1, "Varg", "Grenaderveien 128"));
            data.clients.Add(new Client(2, "Kjetil", "Camlann Place"));
            data.clients.Add(new Client(3, "Andrew", "Tappenhaugen 124"));
            data.vinyls.Add(new Vinyl(0, "Filosofem", "Burzum", 5.99M));
            data.vinyls.Add(new Vinyl(1, "Transylvanian Hunger", "Darkthrone", 3.99M));
            data.vinyls.Add(new Vinyl(2, "De Mysteriis Dom Sathanas", "Mayhem", 4.99M));
            data.vinyls.Add(new Vinyl(3, "Black Metal", "Venom", 2.99M));
            data.vinyls.Add(new Vinyl(4, "With Hearts Toward None", "Mgla", 1.99M));

            data.orders.Add(new Order(0, data.clients[0], data.vinyls[0]));;
            data.orders.Add(new Order(1, data.clients[1], data.vinyls[1]));;
            data.orders.Add(new Order(2, data.clients[2], data.vinyls[2]));;
          
            return data;
        }
    }
}
