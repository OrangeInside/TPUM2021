using System;
using System.Collections.Generic;
using System.Text;

namespace ClientLogic
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public int VinylID { get; set; }
        public string VinylTitle { get; set; }
        public string VinylBand { get; set; }
        public decimal VinylPrice { get; set; }
    }
}
