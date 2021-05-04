using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Factory : IDataGenerator
    {
        public DataContext Generate()
        {
            DataContext data = new DataContext();

            Client c1 = new Client(0, "Odo", "Milorgveien 121");
            Client c2 = new Client(4, "DarkLordOfChaos666", "|m|> Hell <|m|");
            data.clients.Add(c1);
            data.clients.Add(new Client(1, "Varg", "Grenaderveien 128"));
            data.clients.Add(new Client(2, "Kjetil", "Camlann Place"));
            data.clients.Add(new Client(3, "Andrew", "Tappenhaugen 124"));
            data.clients.Add(c2);

            Vinyl v1 = new Vinyl(0, "Filosofem", "Burzum", 5.99M);
            Vinyl v2 = new Vinyl(3, "Black Metal", "Venom", 2.99M);
            data.vinyls.Add(v1);
            data.vinyls.Add(new Vinyl(1, "Transylvanian Hunger", "Darkthrone", 3.99M));
            data.vinyls.Add(new Vinyl(2, "De Mysteriis Dom Sathanas", "Mayhem", 4.99M));
            data.vinyls.Add(v2);
            data.vinyls.Add(new Vinyl(4, "With Hearts Toward None", "Mgla", 1.99M));

            data.orders.Add(new Order(0, c1, v1));
            data.orders.Add(new Order(1, c2, v2));

            return data;
        }
    }
}
