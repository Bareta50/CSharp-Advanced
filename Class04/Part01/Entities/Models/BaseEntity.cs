﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Entities.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
