using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Vinyl
    {
        public string title { get; }
        public string band { get; }
        public decimal price { get; set; }
        
        public Vinyl(string title, string band, decimal price)
        {
            this.title = title;
            this.band = band;
            this.price = price;
        }

        public override string ToString()
        {
            string vinylInfo = "";
            vinylInfo += "Title: " + title;
            vinylInfo += "\tBand: " + band;
            vinylInfo += "\tPrice: " + price + " PLN";
            return vinylInfo;
        }
    }
}
