using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    class Client : IData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public object Clone()
        {
            return new Client() { ID = ID, Name = Name, Adress = Adress };
        }
    }
}
