using System;
using System.Collections.Generic;
using System.Text;
using CommonModel;
using CommonModel.Interfaces;

namespace ClientData
{
    public class DataContext
    {
        public List<IClient> Clients { get; set; } = new List<IClient>();
        public List<IVinyl> Vinyls { get; set; } = new List<IVinyl>();
        public List<IOrder> Orders { get; set; } = new List<IOrder>();
    }
}
