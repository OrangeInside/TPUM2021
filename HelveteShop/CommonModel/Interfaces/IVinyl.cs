using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModel.Interfaces
{
    public interface IVinyl : IData
    {
        string title { get; }
        string band { get; }
        decimal price { get; set; }
    }
}
