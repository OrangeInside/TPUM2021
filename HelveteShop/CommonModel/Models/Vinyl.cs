using System;
using System.Collections.Generic;
using System.Text;
using CommonModel;

namespace CommonModel
{
    public class Vinyl : IVinyl
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Band { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }

        public Vinyl(int ID, string title, string band, decimal price, int inStock)
        {
            this.ID = ID;
            this.Title = title;
            this.Band = band;
            this.Price = price;
            this.InStock = inStock;
        }

        public override string ToString()
        {
            string vinylInfo = "";
            vinylInfo += "Title: " + Title;
            vinylInfo += "\tBand: " + Band;
            vinylInfo += "\tPrice: " + Price + " PLN";
            vinylInfo += "\tInStock: " + InStock;
            return vinylInfo;
        }
    }
}
