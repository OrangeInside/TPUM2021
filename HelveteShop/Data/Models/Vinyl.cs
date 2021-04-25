using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class Vinyl : IData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public object Clone()
        {
            return new Vinyl() { ID = ID, Name = Name, Price = Price };
        }
    }
}
