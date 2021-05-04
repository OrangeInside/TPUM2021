using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Order : IData
    {
        public int ID { get; }
        public Vinyl vinyl { get; set; }
        public Client client { get; set; }

        public Order(int ID, Client client, Vinyl vinyl)
        {
            this.ID = ID;
            this.client = client;
            this.vinyl = vinyl;
        }

        public override string ToString()
        {
            string orderInfo = "";
            orderInfo += "ID: " + ID;
            orderInfo += "\tVinyl: " + vinyl;
            orderInfo += "\tClient: " + client;

            return orderInfo;
        }
    }
}
