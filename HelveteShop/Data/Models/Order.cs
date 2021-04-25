using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Order : IData
    {
        public int ID { get; set; }
        public int ClientID { get; set; }

        public List<Vinyl> vinyls;

        public object Clone()
        {
            return new Order() { ID = ID, ClientID = ClientID, vinyls = vinyls };
        }
    }
}
