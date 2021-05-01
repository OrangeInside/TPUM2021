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

            data.clients.Add(new Client("Odo", "Milorgveien 121"));
            data.clients.Add(new Client("Varg", "Grenaderveien 128"));
            data.clients.Add(new Client("Kjetil", "Camlann Place"));
            data.clients.Add(new Client("Andrew", "Tappenhaugen 124"));

            data.vinyls.Add(new Vinyl("Filosofem", "Burzum", 5.99M ));
            data.vinyls.Add(new Vinyl("Transylvanian Hunger", "Darkthrone", 3.99M));
            data.vinyls.Add(new Vinyl("De Mysteriis Dom Sathanas", "Mayhem", 4.99M));
            data.vinyls.Add(new Vinyl("Black Metal", "Venom", 2.99M));
            data.vinyls.Add(new Vinyl("With Hearts Toward None", "Mgla", 1.99M));

            return data;
        }
    }
}
