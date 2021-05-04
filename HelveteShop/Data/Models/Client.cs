using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Client : IData
    {
        public int ID { get; }
        public string name { get;}
        public string address { get; set; }

        public Client(int id, string name, string address)
        {
            this.ID = id;
            this.name = name;
            this.address = address;
        }

        public override string ToString()
        {
            string clientInfo = "";
            clientInfo += "ID: " + ID;
            clientInfo += "\tName: " + name;
            clientInfo += "\tAddress: " + address;

            return clientInfo;
        }

    }
}
