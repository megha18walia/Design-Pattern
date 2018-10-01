﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
   public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevolutions();
    }
}
