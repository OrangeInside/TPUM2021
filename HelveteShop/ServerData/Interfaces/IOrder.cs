using System;
using System.Collections.Generic;
using System.Text;

namespace ServerData
{
    public interface IOrder : IData
    {
        IVinyl vinyl { get; set; }
        IClient client { get; set; }
    }
}
