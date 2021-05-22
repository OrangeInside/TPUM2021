using System;
using System.Collections.Generic;
using System.Text;

namespace CommonModel.Interfaces
{
    public interface IClient : IData
    {
        string name { get; set; }
        string address { get; set; }
    }
}
