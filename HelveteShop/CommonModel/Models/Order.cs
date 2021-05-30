﻿using System;
using System.Collections.Generic;
using System.Text;
using CommonModel;

namespace CommonModel
{
    public class Order : IOrder
    {
        public int ID { get; set; }
        public IVinyl vinyl { get; set; }
        public IClient client { get; set; }

        public Order(int ID, IClient client, IVinyl vinyl)
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
