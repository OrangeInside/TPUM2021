using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace CommonModel
{
    public class Vinyl : IVinyl
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string band { get; set; }
        public decimal price { get; set; }
        
        public Vinyl(int ID, string title, string band, decimal price)
        {
            this.ID = ID;
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
