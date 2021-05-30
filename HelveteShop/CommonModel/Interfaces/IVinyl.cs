using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModel
{
    public interface IVinyl : IData
    {
        string title { get; set; }
        string band { get; set; }
        decimal price { get; set; }
        int inStock { get; set; }
    }
}
