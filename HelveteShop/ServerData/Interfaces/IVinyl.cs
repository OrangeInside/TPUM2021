using System;
using System.Collections.Generic;
using System.Text;

namespace ServerData
{
    public interface IVinyl : IData
    {
        string Title { get; set; }
        string Band { get; set; }
        decimal Price { get; set; }
        int InStock { get; set; }
    }
}
