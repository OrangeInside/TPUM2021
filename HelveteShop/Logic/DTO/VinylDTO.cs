using System;
using System.Collections.Generic;
using System.Text;

namespace ClientLogic
{
    public class VinylDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Band { get; set; }
        public decimal Price { get; set; }
        public int inStock { get; set; }
    }
}
