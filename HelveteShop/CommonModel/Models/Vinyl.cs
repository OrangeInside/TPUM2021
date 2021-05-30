using System;
using System.Collections.Generic;
using System.Text;
using CommonModel;

namespace CommonModel
{
    public class Vinyl : IVinyl
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string band { get; set; }
        public decimal price { get; set; }
        public int inStock { get; set; }

        public Vinyl(int ID, string title, string band, decimal price, int inStock)
        {
            this.ID = ID;
            this.title = title;
            this.band = band;
            this.price = price;
            this.inStock = inStock;
        }

        public override string ToString()
        {
            string vinylInfo = "";
            vinylInfo += "Title: " + title;
            vinylInfo += "\tBand: " + band;
            vinylInfo += "\tPrice: " + price + " PLN";
            vinylInfo += "\tInStock: " + inStock;
            return vinylInfo;
        }
    }
}
