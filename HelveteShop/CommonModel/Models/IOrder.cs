using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace CommonModel
{
    public class Order : IData
    {
        public int ID { get; }
        public Interfaces.IVinyl vinyl { get; set; }
        public Interfaces.IClient client { get; set; }

        public Order(int ID, Interfaces.IClient client, Interfaces.IVinyl vinyl)
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
