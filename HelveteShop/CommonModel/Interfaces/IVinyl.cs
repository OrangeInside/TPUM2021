using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModel
{
    public interface IVinyl : IData
    {
        string Title { get; set; }
        string Band { get; set; }
        decimal Price { get; set; }
        int InStock { get; set; }
    }
}
