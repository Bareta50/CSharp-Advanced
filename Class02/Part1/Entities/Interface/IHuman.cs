﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Entities.Interface
{
    public interface IHuman
    {
        string GetInfo();
        string GetFullName();
        void Greet(string Name);
        
    }
}
