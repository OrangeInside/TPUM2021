﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IData : ICloneable
    {
        public int ID { get; set; }
    }
}
