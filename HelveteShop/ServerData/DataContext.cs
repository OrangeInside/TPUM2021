using System;
using System.Collections.Generic;
using System.Text;

namespace ServerData
{
    public class DataContext
    {
        private static DataContext instance = null;

        public static DataContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataContext();

                return instance;
            }
        }

        public List<IClient> Clients { get; set; } = new List<IClient>();
        public List<IVinyl> Vinyls { get; set; } = new List<IVinyl>();
        public List<IOrder> Orders { get; set; } = new List<IOrder>();
    }
}
