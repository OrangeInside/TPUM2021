using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IData : ICloneable
    {
        int ID { get; set; }
    }
}
