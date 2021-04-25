using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class Order : IData
    {
        public int ID { get; set; }
        public int ClientID { get; set; }

        public List<int> vinylsID;
        public object Clone()
        {
            return new Order() { ID = ID, ClientID = ClientID, vinylsID = vinylsID };
        }
    }
}
