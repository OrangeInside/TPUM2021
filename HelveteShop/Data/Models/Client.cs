using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Client
    {
        public string name { get;}
        public string address { get; set; }

        public Client(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public override string ToString()
        {
            string clientInfo = "";
            clientInfo += "Name: " + name;
            clientInfo += "\tAddress: " + address;

            return clientInfo;
        }

    }
}
