using System;
using System.Collections.Generic;
using System.Text;
using CommonModel.Interfaces;

namespace CommonModel
{
    public class Client : IClient
    {
        public int ID { get; }
        public string name { get; set; }
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
