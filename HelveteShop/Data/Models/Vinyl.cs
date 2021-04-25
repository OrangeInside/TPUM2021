using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Vinyl : IData
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Band { get; set; }
        public decimal Price { get; set; }

        public object Clone()
        {
            return new Vinyl() { ID = ID, Title = Title, Band = Band, Price = Price };
        }
    }
}
