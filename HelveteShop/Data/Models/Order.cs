using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Order
    {
        public Guid guid { get; }
        public List<Vinyl> vinyls { get; set; }
        public Client client { get; set; }

        public Order(Client client, List<Vinyl> vinyls)
        {
            this.guid = Guid.NewGuid();
            this.client = client;
            this.vinyls = vinyls;
        }

        public override string ToString()
        {
            string orderInfo = "";
            orderInfo += "Guid: " + guid;
            orderInfo += "\tVinyls: " + vinyls;
            orderInfo += "\tClient: " + client;

            return orderInfo;
        }
    }
}
