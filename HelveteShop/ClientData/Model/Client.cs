using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData
{
    public class Client : IClient
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Client(int ID, string name, string address)
        {
            this.ID = ID;
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
